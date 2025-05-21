using FluentValidation;
using MediatR;
using SzkolenieTechniczne2.Cinema.Common.Repositories;
using SzkolenieTechniczne2.Cinema.Domain.Command.Create;
using SzkolenieTechniczne2.Cinema.Domain.Command.Update;

namespace SzkolenieTechniczne2.Cinema.Domain.Command.Update
{
    public class UpdateMovieCommandHandler
    {
        private readonly ApplicationDbContext _context;

        public UpdateMovieCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task HandleAsync(UpdateMovieCommand command)
        {
            // Walidacja komendy
            var validator = new UpdateMovieCommandValidator();
            var validationResult = await validator.ValidateAsync(command);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            // Pobranie istniejącego filmu
            var existingMovie = await _context.Movies
                .FirstOrDefaultAsync(m => m.Id == command.Id);

            if (existingMovie == null)
            {
                throw new KeyNotFoundException($"Movie with ID {command.Id} not found.");
            }

            // Aktualizacja właściwości
            existingMovie.Name = command.Name;
            existingMovie.Year = command.Year;
            existingMovie.Genre = command.Genre;
            existingMovie.Description = command.Description;

            // Zapisanie zmian
            await _context.SaveChangesAsync();
        }
    }
}
