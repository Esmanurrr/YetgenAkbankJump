using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_5_1.Entities;

namespace Week_5_1.Contexts
{
    public class ShopifyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql("Server=91.151.83.102;Port=5432;Database=ShopifyEsmanurMazlum;User Id=ahmetkokteam;Password=obXRMG*U6rJ4R0cbHszpgEuFd;");
        }


    }

}
