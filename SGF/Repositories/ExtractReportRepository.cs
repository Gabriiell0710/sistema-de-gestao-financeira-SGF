using Microsoft.EntityFrameworkCore;
using SGF.Data;
using SGF.DTO;
using SGF.Interfaces.IRepository;

namespace SGF.Repositories
{
    public class ExtractReportRepository : IExtractReportRepository
    {
        private readonly AppDbContext _context;

        public ExtractReportRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ExtractReportDto>> GetExtract(int userId, DateTime start, DateTime end)
        {
            var revenues = _context.Revenues
                .Where(r => r.RevenueCategory.UserId == userId
                && r.Date >= start
                && r.Date <= end)
                .Select(r => new ExtractReportDto
                {
                    Date = r.Date,
                    Type = "Revenue",
                    Description = r.Description,
                    Category = r.RevenueCategory.Name,
                    Value = r.Value
                });

            var expenses = _context.Expenses
                .Where(e => e.ExpenseCategory.UserId == userId
                && e.Date >= start
                && e.Date <= end)
                .Select(e => new ExtractReportDto
                {
                    Date = e.Date,
                    Type = "Expense",
                    Description = e.Description,
                    Category = e.ExpenseCategory.Name,
                    Value = e.Value
                });

            var extract = await revenues
                .Union(expenses)
                .OrderBy(x => x.Date)
                .ToListAsync();

            return extract;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
