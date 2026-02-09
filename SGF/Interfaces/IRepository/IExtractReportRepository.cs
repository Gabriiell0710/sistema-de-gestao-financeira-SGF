using SGF.DTO;

namespace SGF.Interfaces.IRepository
{
    public interface IExtractReportRepository : IDisposable
    {
        Task<List<ExtractReportDto>> GetExtract(int userId, DateTime start, DateTime end);
    }
}
