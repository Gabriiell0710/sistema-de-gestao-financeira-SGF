using SGF.Models;

namespace SGF.Interfaces.IRepository
{
    public interface IRevenueRepository : IDisposable
    {
        Task Add (RevenueModel revenue);
        Task<RevenueModel> GetById(int id);
        Task<List<RevenueModel>> ListByUser(int userId);
        Task Update (RevenueModel revenue);
        Task Delete(RevenueModel revenue);
    }
}
