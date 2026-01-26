using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGF.Models;

namespace SGF.Data.Mapping
{
    public class ExpenseMapping : IEntityTypeConfiguration<ExpenseModel>
    {
        public void Configure(EntityTypeBuilder<ExpenseModel> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Description).HasMaxLength(250).IsRequired();
            builder.Property(e => e.Date).IsRequired();


            builder.HasOne(e => e.ExpenseCategory)
                .WithMany(e => e.Expenses)
                .HasForeignKey(e => e.ExpenseCategoryId)
                .IsRequired();
        }
    }
}
