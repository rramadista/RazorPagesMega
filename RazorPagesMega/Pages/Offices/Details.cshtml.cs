using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMega.Models;

namespace RazorPagesMega.Pages.Offices
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMega.Models.RazorPagesMegaContext _context;

        public DetailsModel(RazorPagesMega.Models.RazorPagesMegaContext context)
        {
            _context = context;
        }

        public Office Office { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Office = await _context.Office.FirstOrDefaultAsync(m => m.ID == id);

            if (Office == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
