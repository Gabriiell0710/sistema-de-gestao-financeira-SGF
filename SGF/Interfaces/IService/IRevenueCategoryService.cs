using SGF.DTO;
using SGF.Models;

namespace SGF.Interfaces.IService
{
    public interface IRevenueCategoryService : IDisposable
    {
        Task Add(RevenueCategoryModel revenueCategory);
        Task<RevenueCategoryModel> GetById(int id);
        Task<List<RevenueCategoryModel>> ListByUser(int userId);
        Task Update(RevenueCategoryDto revenueDto);
        Task Delete(int id);
        Task RevenueCategoryValidation(RevenueCategoryDto revenueDto);
    }
}
