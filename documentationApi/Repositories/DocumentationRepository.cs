using documentationApi.Data;
using documentationApi.Interfaces;
using documentationApi.Models;
using Microsoft.EntityFrameworkCore;

namespace documentationApi.Repositories
{
    public class DocumentationRepository : IDocumentationRepository
    {

        private readonly AppDbContext _context;

        public DocumentationRepository(AppDbContext context)
        {
            _context = context;
        }

        //public async Task<List<Documentation>> GetAll()
        //{
        //    return await _context.Documentations.ToListAsync();            
        //}

        public async Task<Documentation> AddAsync(Documentation doc)
        {
            _context.Documentations.Add(doc);
            await _context.SaveChangesAsync();
            return doc;
        }
    }
}
