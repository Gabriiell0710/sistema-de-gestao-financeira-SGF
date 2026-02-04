using SGF.Models;

namespace SGF.Interfaces.IRepository
{
    public interface IExpenseRepository : IDisposable
    {
        Task Add(ExpenseModel expense);
        Task<ExpenseModel> GetById(int id);
        Task<List<ExpenseModel>> ListByUser(int userId);
        Task Update(ExpenseModel expense);
        Task Delete(ExpenseModel expense);
    }
}
