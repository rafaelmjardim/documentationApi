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

        public async Task<Documentation> AddAsync(Documentation doc)
        {
            await _context.Documentations.AddAsync(doc);
            await _context.SaveChangesAsync();
            return doc;
        }

        public async Task<bool> Remove(int id)
        {
            var doc = await _context.Documentations.FindAsync(id);

            if (doc is null)
                return false;



            _context.Documentations.Remove(doc);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
