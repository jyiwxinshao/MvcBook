using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCBook105.Models;

namespace MVCBook105.Data
{
    public class MVCBook105Context : DbContext
    {
        public MVCBook105Context (DbContextOptions<MVCBook105Context> options)
            : base(options)
        {
        }

        public DbSet<MVCBook105.Models.Book> Book { get; set; } = default!;
        public DbSet<MVCBook105.Models.Borrow> Borrow { get; set; } = default!;
        public DbSet<MVCBook105.Models.Student> Student { get; set; } = default!;
    }
}
