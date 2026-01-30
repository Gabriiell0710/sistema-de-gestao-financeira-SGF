using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGF.Models;

namespace SGF.Data.Mapping
{
    public class RevenueMapping : IEntityTypeConfiguration<RevenueModel>
    {
        public void Configure(EntityTypeBuilder<RevenueModel> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Description).HasMaxLength(250).IsRequired();
            builder.Property(r => r.Value).HasMaxLength(50).IsRequired();
            builder.Property(r => r.Date).IsRequired();


            builder.HasOne(r => r.RevenueCategory)
                .WithMany(r => r.Revenues)
                .HasForeignKey(r => r.RevenueCategoryId)
                .IsRequired();

        }
    }
}
