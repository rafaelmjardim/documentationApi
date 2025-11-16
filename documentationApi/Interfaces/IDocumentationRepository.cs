using documentationApi.Models;

namespace documentationApi.Interfaces
{
    public interface IDocumentationRepository
    {
        public Task<Documentation> AddAsync(Documentation doc);
        public Task<bool> Remove(int id);
    }
}
