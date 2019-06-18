using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EbiMiMi.Models;
using Microsoft.AspNetCore.Authorization;

namespace EbiMiMi.Pages.ImageControl
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly EbiMiMi.Models.ApplicationDbContext _context;

        public DetailsModel(EbiMiMi.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public Gallery Gallery { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gallery = await _context.GalleryImages.FirstOrDefaultAsync(m => m.Id == id);

            if (Gallery == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
