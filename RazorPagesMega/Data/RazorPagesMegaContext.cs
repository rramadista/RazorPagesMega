using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMega.Models
{
    public class RazorPagesMegaContext : DbContext
    {
        public RazorPagesMegaContext (DbContextOptions<RazorPagesMegaContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMega.Models.Office> Office { get; set; }
    }
}
