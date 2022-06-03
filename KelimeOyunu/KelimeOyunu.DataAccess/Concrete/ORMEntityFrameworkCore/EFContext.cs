using KelimeOyunu.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KelimeOyunu.DataAccess.Concrete.ORMEntityFrameworkCore
{
    public class EFContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-O1AASO9\SQLEXPRESS;Initial Catalog=kelimeoyunu;Integrated Security=True");
        }

        public DbSet<Kelime> Kelimeler { get; set; }
        public DbSet<Oturum> Oturumlar { get; set; }
        public DbSet<Surec> Surecler { get; set; }
    }
}
