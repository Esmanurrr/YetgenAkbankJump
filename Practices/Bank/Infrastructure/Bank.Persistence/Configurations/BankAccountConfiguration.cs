using Bank.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Persistence.Configurations
{
    internal class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            //ID - Primary Key
            builder.HasKey(x => x.Id); // best practice
            builder.Property(x => x.Id).ValueGeneratedOnAdd(); // to increase one by one Id value

            //FirstName
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(60);

            //LastName
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(60);

            // PhoneNumer
            builder.Property(x => x.PhoneNumber).IsRequired();

            // Balance
            builder.Property(x => x.Balance).IsRequired();

            // CreatedByUserId
            builder.Property(x => x.CreatedByUserId).IsRequired();
            builder.Property(x => x.CreatedByUserId).HasMaxLength(75);

            // CreatedOn
            builder.Property(x => x.CreatedOn).IsRequired();

            // DeletedOn
            builder.Property(x => x.DeletedOn).IsRequired(false);

           
        }
    }
}
