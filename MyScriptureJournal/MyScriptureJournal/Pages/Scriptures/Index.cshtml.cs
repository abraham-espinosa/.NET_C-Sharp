using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }
        public string BookSort { get; set; }
        public string DateSort { get; set; }
        public IList<Scripture> Scripture { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Books { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ScriptureBook { get; set;}

        public async Task OnGetAsync(string sortOrder)
        {
            BookSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<Scripture> scriptureIQ = from s in _context.Scripture
                                                select s;

            switch (sortOrder)
            {
                case "name_desc":
                    scriptureIQ = scriptureIQ.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    scriptureIQ = scriptureIQ.OrderBy(s => s.ReleaseDate);
                    break;
                case "date_desc":
                    scriptureIQ = scriptureIQ.OrderByDescending(s => s.ReleaseDate);
                    break;
                default:
                    scriptureIQ = scriptureIQ.OrderBy(s => s.Book);
                    break;
            }

            // Use LINQ to get list of books.
            IQueryable<string> bookQuery = from m in _context.Scripture
                                           orderby m.Book
                                           select m.Book;

            //var scriptures = from m in _context.Scripture
            //             select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptureIQ = scriptureIQ.Where(s => s.Note.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(ScriptureBook))
            {
                scriptureIQ = scriptureIQ.Where(x => x.Book == ScriptureBook);
            }
            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
            Scripture = await scriptureIQ.AsNoTracking().ToListAsync();
        }
    }   
}
