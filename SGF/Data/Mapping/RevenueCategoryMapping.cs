using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGF.Models;

namespace SGF.Data.Mapping
{
    public class RevenueCategoryMapping : IEntityTypeConfiguration<RevenueCategoryModel>
    {
        public void Configure(EntityTypeBuilder<RevenueCategoryModel> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Name).HasMaxLength(100).IsRequired();

            builder.HasOne(r => r.User)
                .WithMany(u => u.RevenueCategory)
                .HasForeignKey(r => r.UserId)
                .IsRequired();

            builder.HasMany(r => r.Revenues)
                .WithOne(r => r.RevenueCategory)
                .HasForeignKey(r => r.RevenueCategoryId);



        }
    }
}
