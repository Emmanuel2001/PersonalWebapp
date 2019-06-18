using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EbiMimi.Models
{
    public class EbiMimiContext : DbContext
    {
        public EbiMimiContext (DbContextOptions<EbiMimiContext> options)
            : base(options)
        {
        }

        public DbSet<EbiMimi.Models.Media> Media { get; set; }
        public DbSet<EbiMimi.Models.Photo> Photos { get; set; }
    }
}
