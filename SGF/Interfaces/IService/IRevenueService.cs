using SGF.DTO;
using SGF.Models;

namespace SGF.Interfaces.IService
{
    public interface IRevenueService : IDisposable
    {
        Task Add(RevenueModel revenue);
        Task<RevenueModel> GetById (int id);
        Task<List<RevenueModel>> ListByUser(int userId);
        Task Update(RevenueDto dto);
        Task Delete(int id);
        Task RevenueValidation(RevenueDto revenue);
        void IdRevenueSelected(int id);
    }
}
