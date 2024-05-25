using Elektrik_Urun_Listele.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elektrik_Urun_Listele.DBContext
{
    public class Context:DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=DESKTOP-UJN0AMJ\\SQLEXPRESS;Database=CoskunUrunTakipDB;integrated security = true ; TrustServerCertificate = true");
        }
    }
}
