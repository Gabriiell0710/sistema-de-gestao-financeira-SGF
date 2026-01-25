using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGF.Models;

namespace SGF.Data.Mapping
{
    public class ExpensesMapping : IEntityTypeConfiguration<ExpensesModel>
    {
        public void Configure(EntityTypeBuilder<ExpensesModel> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Description).HasMaxLength(250).IsRequired();
            builder.Property(e => e.Date).IsRequired();

            builder.HasOne(e => e.ExpenseCategory.User)
                .WithMany(u => u.Expenses)
                .HasForeignKey(e => e.ExpenseCategory.UserId)
                .IsRequired();

            builder.HasOne(e => e.ExpenseCategory)
                .WithMany(e => e.Expenses)
                .HasForeignKey(e => e.ExpenseCategoryId)
                .IsRequired();
        }
    }
}
