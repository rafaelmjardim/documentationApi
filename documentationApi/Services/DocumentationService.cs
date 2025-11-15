using documentationApi.Dto;
using documentationApi.Interfaces;
using documentationApi.Models;

namespace documentationApi.Services
{
    public class DocumentationService : IDocumentationService
    {

        private readonly IDocumentationRepository _repo;

        public DocumentationService(IDocumentationRepository repo)
        {
            _repo = repo;
        }

        public async Task<Documentation> Create(DocumentationDto doc) {
            if (doc == null)
            {
                return null;
            }

            var newDoc = new Documentation
            {
                Title = doc.Title,
                Patch = doc.Patch,
                Content = doc.Content
            };

            await _repo.AddAsync(newDoc);

            return newDoc;
        }
    }
}
