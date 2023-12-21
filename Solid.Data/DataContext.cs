using Microsoft.EntityFrameworkCore;
using project_Riki_Mittelman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class DataContext:DbContext
    {
        public DbSet<AvaibleProducts> avaibleProducts { get; set; }
        public DbSet<AviableProduct> recepies { get; set; }
        public DbSet<ShopingList> shopingLists { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=sample_db");
        }

    }
}
