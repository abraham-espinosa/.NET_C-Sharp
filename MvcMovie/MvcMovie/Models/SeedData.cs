using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("2003-2-12"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 2,
                        ImageName = "TheRM.jpg"
                    },

                    new Movie
                    {
                        Title = "Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-3-13"),
                        Genre = "Adventure",
                        Rating = "PG-13",
                        Price = 3,
                        ImageName = "OtherSideofHeaven.jpg"
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-2-23"),
                        Genre = "Documentary",
                        Rating = "PG",
                        Price = 10,
                        ImageName = "MeetheMormons.jpg"
                    },

                    new Movie
                    {
                        Title = "The Book of Mormon",
                        ReleaseDate = DateTime.Parse("2003-4-15"),
                        Genre = "Adventure",
                        Rating = "PG-13",
                        Price = 5,
                        ImageName = "BookofMormon.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
