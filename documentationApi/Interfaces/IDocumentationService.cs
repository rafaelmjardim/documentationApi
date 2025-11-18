using documentationApi.Dto;
using documentationApi.Models;

namespace documentationApi.Interfaces
{
    public interface IDocumentationService
    {
        Task<List<Documentation>> GetAllDocumentations();
        Task<Documentation> Create(DocumentationDto doc);
        Task<bool> Delete(int id);
    }
}
