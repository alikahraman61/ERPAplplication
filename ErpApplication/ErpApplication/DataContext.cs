using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpApplication
{
    internal class DataContext:DbContext
    {
        public DataContext() : base("connection") { }

        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<Siparis> Siparis { get; set; }
    }
}
