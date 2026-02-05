using SGF.DTO;
using SGF.Models;

namespace SGF.Interfaces.IService
{
    public interface IExpenseService : IDisposable
    {
        Task Add(ExpenseModel expense);
        Task<ExpenseModel> GetById(int id);
        Task<List<ExpenseModel>> ListByUser(int userId);
        Task Update(ExpenseDto dto);
        Task Delete(int id);
        Task ExpenseValidation(ExpenseDto expense);
        void IdExpenseSelected(int id);
    }
}
