using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EbiMimi.Models;

namespace EbiMimi.Pages.Memories
{
    public class DeleteModel : PageModel
    {
        private readonly EbiMimi.Models.EbiMimiContext _context;

        public DeleteModel(EbiMimi.Models.EbiMimiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Media Media { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Media = await _context.Media.FirstOrDefaultAsync(m => m.ID == id);

            if (Media == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Media = await _context.Media.FindAsync(id);

            if (Media != null)
            {
                _context.Media.Remove(Media);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
