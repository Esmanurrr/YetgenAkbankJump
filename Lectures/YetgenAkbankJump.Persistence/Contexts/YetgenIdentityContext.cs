using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YetgenAkbankJump.Domain.Entities;
using YetgenAkbankJump.Domain.Identity;

namespace YetgenAkbankJump.Persistence.Contexts
{
    public class YetgenIdentityContext:IdentityDbContext<User,Role,Guid>
    {
        public YetgenIdentityContext(DbContextOptions<YetgenIdentityContext> options) : base(options)
        {
        }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Ignore<Student>();
            builder.Ignore<Product>();
            builder.Ignore<Category>();
            builder.Ignore<ProductCategory>();

            base.OnModelCreating(builder);
        }
    }
}
