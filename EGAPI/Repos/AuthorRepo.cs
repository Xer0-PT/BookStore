using EGAPI.Data;
using EGAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EGAPI.Repos
{
    public class AuthorRepo : IAuthorRepo
    {
        private readonly DataContext _context;

        public AuthorRepo(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task <IEnumerable<Author>> GetAllAuthors()
        {
            var authors = await _context.Authors.ToListAsync();
            return authors;
        }

        public async Task<Author> GetAuthorByID(int id)
        {
            var author = await _context.Authors.FindAsync(id);

            return author;
        }

        public async Task<Author> UpdateAuthor(int id, Author author)
        {
            _context.Entry(author).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorExists(id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
            return author;
        }

        public async Task<Author> NewAuthor(Author author)
        {
            _context.Authors.Add(author);
            await _context.SaveChangesAsync();

            return author;
        }

        public async Task<Author> DeleteAuthor(int id)
        {
            var author = await _context.Authors.FirstOrDefaultAsync(e => e.Id == id);

            if (author == null)
            {
                return null;
            }

            _context.Authors.Remove(author);
            await _context.SaveChangesAsync();

            return author;
        }

        public bool AuthorExists(int id)
        {
            return _context.Authors.Any(e => e.Id == id);
        }
    }
}
