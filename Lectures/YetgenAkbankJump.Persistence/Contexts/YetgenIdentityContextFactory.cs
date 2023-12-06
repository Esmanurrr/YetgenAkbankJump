using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetgenAkbankJump.Persistence.Contexts
{
    public class YetgenIdentityContextFactory : IDesignTimeDbContextFactory<YetgenIdentityContext>
    {
        public YetgenIdentityContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) 
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<YetgenIdentityContext>();

            var connectionString = configuration.GetConnectionString("PostgreSQL");

            optionsBuilder.UseNpgsql(connectionString);

            return new YetgenIdentityContext(optionsBuilder.Options);
        }
    }
}
