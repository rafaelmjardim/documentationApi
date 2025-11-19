using documentationApi.Models;

namespace documentationApi.Interfaces
{
    public interface IDocumentationRepository
    {
        public Task<List<Documentation>> ListAsync();
        Task<Documentation?> FindAsync(int id);
        public Task<Documentation> AddAsync(Documentation doc);
        public Task<bool> Remove(int id);
    }
}
