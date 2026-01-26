using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGF.Models;

namespace SGF.Data.Mapping
{
    public class ExpenseCategoryMapping : IEntityTypeConfiguration<ExpenseCategoryModel>
    {
        public void Configure(EntityTypeBuilder<ExpenseCategoryModel> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();

            builder.HasOne(e => e.User)
                .WithMany(u => u.ExpenseCategory)
                .HasForeignKey(e => e.UserId)
                .IsRequired();          
        }
    }
}
