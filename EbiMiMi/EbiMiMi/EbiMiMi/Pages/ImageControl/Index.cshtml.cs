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
    public class IndexModel : PageModel
    {
        private readonly EbiMiMi.Models.ApplicationDbContext _context;

        public IndexModel(EbiMiMi.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Gallery> Gallery { get;set; }

        public async Task OnGetAsync()
        {
            Gallery = await _context.GalleryImages.ToListAsync();
        }
    }
}
