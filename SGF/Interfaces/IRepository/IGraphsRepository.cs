using SGF.DTO;

namespace SGF.Interfaces.IRepository
{
    public interface IGraphsRepository : IDisposable
    {
        Task<List<GraphsDto>> GetRevenues(int userId, int year, int month);
        Task<List<GraphsDto>> GetExpenses(int userId, int year, int month);
        Task<(List<GraphsDto> Revenues, List<GraphsDto> Expenses)> GetCompare(int userId, int year, int month);

    }
}
