using SzkolenieTechniczne2.Cinema.Common.Repositories;
using SzkolenieTechniczne2.Cinema.Domain.Entities;
using SzkolenieTechniczne2.Cinema.Infrastructure.Repository;
using SzkolenieTechniczne2.Cinema.Infrastructure;



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using (var context = new CinemaTicketDbContext(
new
Microsoft.EntityFrameworkCore.DbContextOptions<CinemaTicketDbContext>()))
{
    await context.AddAsync(new MovieCategory("Przygodowy")); //Zakomentować po pierwszym wykonaniu w bazie 
    await context.SaveChangesAsync();  //Zakomentować po pierwszym wykonaniu w bazie 
                                       //Jest lepszy sposób na tabele na start, ale proście tak będzie

    IMoviesRepository moviesRepository = new MoviesRepository(context);
    await moviesRepository.AddAsync(new Movie("Matrix", 2000, 120, 1));
    await moviesRepository.AddAsync(new Movie("Krzyżacy", 1961, 180, 1));
    IEnumerable<Movie> movieList = await moviesRepository.GetAllAsync();
    foreach (Movie movie in movieList)
        Console.WriteLine(movie.Name);
}
