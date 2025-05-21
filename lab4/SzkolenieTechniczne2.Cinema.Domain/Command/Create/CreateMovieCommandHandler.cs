using FluentValidation;
using MediatR;
using SzkolenieTechniczne2.Cinema.Common.Repositories;
using SzkolenieTechniczne2.Cinema.Domain.Command.Create;
using SzkolenieTechniczne2.Cinema.Domain.Command.Update;

namespace SzkolenieTechniczne2.Cinema.Domain.Command.Movie.Create
{
    public class CreateMovieCommandHandler : IRequestHandler<CreateMovieCommand, Result>
    {
        private readonly IMoviesRepository _moviesRepository;

        public CreateMovieCommandHandler(IMoviesRepository moviesRepository)
        {
            _moviesRepository = moviesRepository;
        }

        public async Task<Result> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateMovieCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);
            if (!validationResult.IsValid)
            {
                return Result.Fail(validationResult.ToString());
            }

            if (await _moviesRepository.IsMovieExistAsync(request.Name, request.Year))
            {
                return Result.Fail("Ten film już istnieje.");
            }

            var movie = new SzkolenieTechniczne2.Cinema.Domain.Entities.Movie(
                request.Name,
                request.Year,
                request.SeanceTime,
                request.MovieCategoryId);

            await _moviesRepository.AddAsync(movie);

            return Result.Ok();
        }
    }
}


