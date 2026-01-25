using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGF.Models;

namespace SGF.Data.Mapping
{
    public class RevenuesMapping : IEntityTypeConfiguration<RevenuesModel>
    {
        public void Configure(EntityTypeBuilder<RevenuesModel> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Name).HasMaxLength(100).IsRequired();
            builder.Property(r => r.Description).HasMaxLength(250).IsRequired();
            builder.Property(r => r.Date).IsRequired();

            builder.HasOne(r => r.RevenueCategory.User)
                .WithMany(u => u.Revenues)
                .HasForeignKey(r => r.RevenueCategory.UserId)
                .IsRequired();

            builder.HasOne(r => r.RevenueCategory)
                .WithMany(r => r.Revenues)
                .HasForeignKey(r => r.RevenueCategoryId)
                .IsRequired();

        }
    }
}
