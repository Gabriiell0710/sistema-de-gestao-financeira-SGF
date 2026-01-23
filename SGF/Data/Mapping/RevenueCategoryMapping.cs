using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGF.Data.Mapping
{
    public class RevenueCategoryMapping : IEntityTypeConfiguration<RevenueCategoryModel>
    {
        public void Configure(EntityTypeBuilder<RevenueCategoryModel> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name).HasMaxLength(100).IsRequired();

            builder.HasOne(r => r.User).HasForeignKey




        }
    }
}
