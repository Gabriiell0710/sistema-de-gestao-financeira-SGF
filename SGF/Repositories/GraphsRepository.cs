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

        public async Task<List<GraphsDto>> GetRevenues(int userId, int year, int month)
        {
            var start = new DateTime(year, month, 1);
            var end = start.AddMonths(1);

            var raw = await _context.Revenues
                .Where(r => r.RevenueCategory.UserId == userId
                        && r.Date >= start
                        && r.Date < end)
                .GroupBy(r => r.Date.Day)
                .Select(g => new
                {
                    Day = g.Key,
                    Value = g.Sum(x => (double)x.Value)
                })
                .OrderBy(x => x.Day)
                .ToListAsync();
                
            
            var data = raw.Select(x => new GraphsDto
            {
                Month = x.Day.ToString(),
                Value = (decimal)x.Value
            })
                .ToList();

            return data;

        }


        public async Task<List<GraphsDto>> GetExpenses(int userId, int year, int month)
        {
            var start = new DateTime(year, month, 1);
            var end = start.AddMonths(1);

            var raw = await _context.Expenses
                .Where(e => e.ExpenseCategory.UserId == userId 
                        && e.Date >= start
                        && e.Date < end)
                .GroupBy(r => r.Date.Day)
                .Select(g => new
                {
                    Day = g.Key,
                    Value = g.Sum(x => (double)x.Value)
                })
                .OrderBy(x => x.Day)
                .ToListAsync();


            var data = raw.Select(x => new GraphsDto
            {
                Month = x.Day.ToString(),
                Value = (decimal)x.Value
            })
                .ToList();

            return data;
        }


        public async Task<(List<GraphsDto> Revenues, List<GraphsDto> Expenses)> GetCompare(int userId, int year, int month)
        {
            var revenues = await GetRevenues(userId, year, month);
            var expenses = await GetExpenses(userId, year, month);

            return (revenues, expenses);
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }


    }
}
