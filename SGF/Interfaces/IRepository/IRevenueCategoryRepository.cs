using SGF.Models;

namespace SGF.Interfaces.IRepository
{
    public interface IRevenueCategoryRepository : IDisposable
    {
        Task Add(RevenueCategoryModel revenueCategory);
        Task<RevenueCategoryModel> GetById(int id);
        Task<List<RevenueCategoryModel>> ListByUser (int  userId);
        Task Update(RevenueCategoryModel revenue);
        Task Delete(RevenueCategoryModel revenue);
    }
}
