using Microsoft.EntityFrameworkCore;
using SGF.Data;
using SGF.Interfaces.IRepository;
using SGF.Models;

namespace SGF.Repositories
{
    public class ExpenseCategoryRepository : IExpenseCategoryRepository
    {
        private readonly AppDbContext _context;

        public ExpenseCategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        
        public async Task Add(ExpenseCategoryModel expenseCategory)
        {
            await _context.ExpenseCategories.AddAsync(expenseCategory);
            await _context.SaveChangesAsync();
        }


        public async Task<ExpenseCategoryModel> GetById(int id)
        {
            var expense = await _context.ExpenseCategories
                .Where(x => x.Id == id).FirstOrDefaultAsync();
            return expense;
        }


        public async Task<List<ExpenseCategoryModel>> ListByUser(int userId)
        {
            var list = await _context.ExpenseCategories
                .Where(x => x.UserId == userId).ToListAsync();
            return list;
        }


        public async Task Update(ExpenseCategoryModel expense)
        {
             _context.ExpenseCategories.Update(expense);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(ExpenseCategoryModel expense)
        {
             _context.ExpenseCategories.Remove(expense);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


    }
}
