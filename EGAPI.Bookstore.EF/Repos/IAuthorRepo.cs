using EGAPI.Bookstore.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EGAPI.Bookstore.Application.Interfaces
{
    public interface IAuthorRepo
    {
        Task<IEnumerable<Author>> GetAllAuthors();
        Task<Author> GetAuthorByID(int id);
        Task<Author> UpdateAuthor(int id, Author author);
        Task<Author> NewAuthor(Author author);
        Task<Author> DeleteAuthor(int id);
        bool AuthorExists(int id);
    }
}