using documentationApi.Models;

namespace documentationApi.Interfaces
{
    public interface IDocumentationRepository
    {
        Task<List<Documentation>> ListAsync();
        Task<Documentation?> FindAsync(int id);
        Task<Documentation> AddAsync(Documentation doc);
        Task<bool> Remove(int id);
    }
}
