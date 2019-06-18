using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EbiMimi.Models;

namespace EbiMimi.Pages.Memories
{
    public class CreateModel : PageModel
    {
        private readonly EbiMimi.Models.EbiMimiContext _context;

        public CreateModel(EbiMimi.Models.EbiMimiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Media Media { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Media.Add(Media);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}