using KatalogProduk.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatalogProduk.Data
{
    public class KatalogProdukContext : DbContext
    {
        public KatalogProdukContext(DbContextOptions<KatalogProdukContext> opt) : base(opt)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Produk> Produks { get; set; }
    }
}
