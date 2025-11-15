namespace documentationApi.Interfaces
{
    public interface IDocumentationService
    {
        Task<string> GetAllDocumentations();
        Task AddDocumentation();
    }
}
