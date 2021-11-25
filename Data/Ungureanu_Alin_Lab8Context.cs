using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ungureanu_Alin_Lab8.Models;

namespace Ungureanu_Alin_Lab8.Data
{
    public class Ungureanu_Alin_Lab8Context : DbContext
    {
        public Ungureanu_Alin_Lab8Context (DbContextOptions<Ungureanu_Alin_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Ungureanu_Alin_Lab8.Models.Book> Book { get; set; }

        public DbSet<Ungureanu_Alin_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Ungureanu_Alin_Lab8.Models.Category> Category { get; set; }
    }
}
