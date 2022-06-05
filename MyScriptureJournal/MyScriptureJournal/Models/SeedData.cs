using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                if (context == null || context.Scripture == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Label = "Romantic Comedy",
                        Note = "Faith"
                    },

                    new Scripture
                    {
                        Book = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Label = "Romantic Comedy",
                        Note = "Faith"
                    },

                    new Scripture
                    {
                        Book = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Label = "Romantic Comedy",
                        Note = "Faith"
                    },

                    new Scripture
                    {
                        Book = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Label = "Romantic Comedy",
                        Note = "Faith"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
