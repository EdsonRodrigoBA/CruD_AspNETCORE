using Crud_AspNetCore.Models;
using Crud_AspNetCore.Models.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Crud_AspNetCore.Models.Dados;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FilmesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FilmesContext>>()))
            {
                // Look for any movies.
                if (context.Filme.Any())
                {
                    return;   // DB has been seeded
                }

                context.Filme.AddRange(
                    new Filme
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R"
                    },

                    new Filme
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "M"
                    },

                    new Filme
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "M"
                    },

                    new Filme
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "R"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}