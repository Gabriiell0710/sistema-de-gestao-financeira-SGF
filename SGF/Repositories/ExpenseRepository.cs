using Microsoft.EntityFrameworkCore;
using SGF.Data;
using SGF.Interfaces.IRepository;
using SGF.Models;

namespace SGF.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly AppDbContext _context;

        public ExpenseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Add(ExpenseModel expense)
        {
            await _context.Expenses.AddAsync(expense);
            await _context.SaveChangesAsync();
        }


        public async Task<ExpenseModel> GetById(int id)
        {
            return await _context.Expenses
                .Where(x => x.Id == id).FirstOrDefaultAsync();
        }


        public async Task<List<ExpenseModel>> ListByUser(int userId)
        {
            return await _context.Expenses
                .Where(x => x.ExpenseCategory.UserId == userId).ToListAsync();
        }


        public async Task Update(ExpenseModel expense)
        {
           _context.Update(expense);
            await _context.SaveChangesAsync();
        }


        public async Task Delete(ExpenseModel expense)
        {
             _context.Expenses.Remove(expense);
            await _context.SaveChangesAsync();
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }


    }
}
