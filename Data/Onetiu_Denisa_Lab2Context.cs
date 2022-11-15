using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Onetiu_Denisa_Lab2.Models;

namespace Onetiu_Denisa_Lab2.Data
{
    public class Onetiu_Denisa_Lab2Context : DbContext
    {
        public Onetiu_Denisa_Lab2Context (DbContextOptions<Onetiu_Denisa_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Onetiu_Denisa_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Onetiu_Denisa_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Onetiu_Denisa_Lab2.Models.Category> Category { get; set; }

        public DbSet<Onetiu_Denisa_Lab2.Models.Author> Author { get; set; }

        public DbSet<Onetiu_Denisa_Lab2.Models.Member> Member { get; set; }

        public DbSet<Onetiu_Denisa_Lab2.Models.Borrowing> Borrowing { get; set; }
    }
}
