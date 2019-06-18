using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EbiMimi.Models;

namespace EbiMimi.Pages.Memories
{
    public class EditModel : PageModel
    {
        private readonly EbiMimi.Models.EbiMimiContext _context;

        public EditModel(EbiMimi.Models.EbiMimiContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Media).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MediaExists(Media.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MediaExists(int id)
        {
            return _context.Media.Any(e => e.ID == id);
        }
    }
}
