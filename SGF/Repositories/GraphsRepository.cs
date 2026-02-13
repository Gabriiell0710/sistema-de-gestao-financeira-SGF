using Microsoft.EntityFrameworkCore;
using SGF.Data;
using SGF.DTO;
using SGF.Interfaces.IRepository;

namespace SGF.Repositories
{
    public class GraphsRepository : IGraphsRepository
    {
        private readonly AppDbContext _context;

        public GraphsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<GraphsDto>> GetRevenues(int userId)
        {
            var data = await _context.Revenues
                .Where(r => r.RevenueCategory.UserId == userId)
                .GroupBy(r => new { r.Date.Year, r.Date.Month })
                .Select(g => new GraphsDto
                {
                    Month = $"{g.Key.Month:00}/{g.Key.Year}",
                    Value = g.Sum(x => x.Value)
                })
                .OrderBy(x => x.Month)
                .ToListAsync();
            return data;
        }


        public async Task<List<GraphsDto>> GetExpenses(int userId)
        {
            var data = await _context.Expenses
                .Where(e => e.ExpenseCategory.UserId == userId)
                .GroupBy(e => new { e.Date.Year, e.Date.Month })
                .Select(g => new GraphsDto
                {
                    Month = $"{g.Key.Month:00}/{g.Key.Year}",
                    Value = g.Sum(x => x.Value)
                })
                .OrderBy(x => x.Month)
                .ToListAsync();
            return data;
        }


        public async Task<(List<GraphsDto> Revenues, List<GraphsDto> Expenses)> GetCompare(int userId)
        {
            var revenues = await GetRevenues(userId);
            var expenses = await GetExpenses(userId);

            return (revenues, expenses);
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }


    }
}
