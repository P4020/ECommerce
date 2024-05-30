using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Models;

    public class dbContext : DbContext
    {
        public dbContext (DbContextOptions<dbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=Database.db");
        public DbSet<Ecommerce.Models.Game> Game { get; set; } = default!;

        public DbSet<Ecommerce.Models.User> User { get; set; } = default!;

        public DbSet<Ecommerce.Models.Carrello> Carrello { get; set; } = default!;
    }
