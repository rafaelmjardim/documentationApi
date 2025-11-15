using documentationApi.Interfaces;

namespace documentationApi.Services
{
    public class DocumentationService : IDocumentationService
    {
        public async Task<string> GetAllDocumentations()
        {
            
            return "GetAllDocumentation rodando";
        }

        public async Task AddDocumentation()
        {

        }
    }
}
