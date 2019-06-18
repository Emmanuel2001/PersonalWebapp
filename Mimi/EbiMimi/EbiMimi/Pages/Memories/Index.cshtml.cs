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
    public class IndexModel : PageModel
    {
        private readonly EbiMimi.Models.EbiMimiContext _context;

        public IndexModel(EbiMimi.Models.EbiMimiContext context)
        {
            _context = context;
        }

        public IList<Media> Media { get;set; }

        public async Task OnGetAsync()
        {
            Media = await _context.Media.ToListAsync();
        }
    }
}
