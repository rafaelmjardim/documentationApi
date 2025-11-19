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

        public async Task<List<Documentation>> GetAllDocumentations()
        {
            return await _repo.ListAsync();
        }

        public async Task<Documentation?> GetById(int id)
        {
            return await _repo.FindAsync(id);
        }

        public async Task<Documentation> Create(DocumentationDto doc) {
            if (doc is null)
                throw new ArgumentException(nameof(doc));
            


            if (string.IsNullOrWhiteSpace(doc.Title))
                throw new ArgumentException("Título obrigatório.");

            if (string.IsNullOrWhiteSpace(doc.Patch))
                throw new ArgumentException("Patch obrigatório.");


            var newDoc = new Documentation
            {
                Title = doc.Title,
                Patch = doc.Patch,
                Content = doc.Content
            };

            await _repo.AddAsync(newDoc);

            return newDoc;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repo.Remove(id);      
        }

        public async Task<bool> Update(int id, DocumentationDto docDto)
        {
            var doc = await _repo.FindAsync(id);


            if (doc is null)
                return false;

            doc.Title = docDto.Title;
            doc.Patch = docDto.Patch;
            doc.Content = docDto.Content;

            await _repo.UpdateAsync(doc);
            return true;
        }
    }
}
