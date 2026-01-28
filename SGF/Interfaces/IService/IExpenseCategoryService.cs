using SGF.DTO;
using SGF.Models;

namespace SGF.Interfaces.IService
{
    public interface IExpenseCategoryService : IDisposable
    {
        Task Add(ExpenseCategoryModel expenseCategory);
        Task<ExpenseCategoryModel> GetById(int id);
        Task<List<ExpenseCategoryModel>> ListByUser(int userId);
        Task Update(ExpenseCategoryDto expenseDto);
        Task Delete(int id);
        Task ExpenseCategoryValidation(ExpenseCategoryDto expenseDto);
        void IdExpenseSelected(int id);
    }
}
