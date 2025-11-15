using documentationApi.Dto;
using documentationApi.Models;

namespace documentationApi.Interfaces
{
    public interface IDocumentationService
    {
        Task<Documentation> Create(DocumentationDto doc);
    }
}
