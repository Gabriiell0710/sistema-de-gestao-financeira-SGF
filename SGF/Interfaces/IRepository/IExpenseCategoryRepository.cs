using SGF.Models;

namespace SGF.Interfaces.IRepository
{
    public interface IExpenseCategoryRepository : IDisposable
    {
        Task Add(ExpenseCategoryModel expenseCategory);
        Task<ExpenseCategoryModel> GetById(int id);
        Task<List<ExpenseCategoryModel>> ListByUser(int userId);
        Task Update(ExpenseCategoryModel expense);
        Task Delete(ExpenseCategoryModel expense);
    }
}
