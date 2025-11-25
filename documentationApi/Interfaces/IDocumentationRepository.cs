using documentationApi.Models;

namespace documentationApi.Interfaces
{
    public interface IDocumentationRepository
    {
        Task<List<Documentation>> ListAsync();
        Task<Documentation?> FindAsync(int id);
        Task<Documentation> AddAsync(Documentation doc);
        Task Remove(Documentation doc);
        Task UpdateAsync(Documentation doc);
    }
}
