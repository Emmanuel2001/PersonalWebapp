using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EbiMimi.Models;
using EbiMimi.Utilities;

namespace EbiMimi.Pages.UploadPhoto
{
    public class IndexModel : PageModel
    {
        private readonly EbiMimi.Models.EbiMimiContext _context;

        public IndexModel(EbiMimi.Models.EbiMimiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FileUpload FileUpload { get; set; }

        public IList<Photo> Photos { get; private set; }

        public async Task OnGetAsync()
        {
            Photos = await _context.Photos.AsNoTracking().ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Perform an initial check to catch FileUpload class
            // attribute violations.
            if (!ModelState.IsValid)
            {
                Photos = await _context.Photos.AsNoTracking().ToListAsync();
                return Page();
            }

            var publicScheduleData =
                await FileHelpers.ProcessFormFile(FileUpload.UploadPublicSchedule, ModelState);

            // Perform a second check to catch ProcessFormFile method
            // violations.
            if (!ModelState.IsValid)
            {
                Photos = await _context.Photos.AsNoTracking().ToListAsync();
                return Page();
            }

            var photo = new Photo()
            {
                PublicSchedule = publicScheduleData,
                Title = FileUpload.Title,
                UploadDT = DateTime.UtcNow
            };

            _context.Photos.Add(photo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./IndexFile");
        }
    }
}