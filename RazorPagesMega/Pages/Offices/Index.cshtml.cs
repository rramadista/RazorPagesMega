using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMega.Models;

namespace RazorPagesMega.Pages.Offices
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMega.Models.RazorPagesMegaContext _context;

        public IndexModel(RazorPagesMega.Models.RazorPagesMegaContext context)
        {
            _context = context;
        }

        public IList<Office> Office { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList OfficeNames { get; set; }
        [BindProperty(SupportsGet = true)]
        public string OfficeCategory { get; set; }

        public async Task OnGetAsync()
        {
            var offices = from m in _context.Office
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                offices = offices.Where(s => s.OfficeName.Contains(SearchString));
            }

            Office = await offices.ToListAsync();
        }
    }
}
