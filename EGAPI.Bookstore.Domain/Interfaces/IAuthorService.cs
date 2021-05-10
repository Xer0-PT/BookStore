using EGAPI.Bookstore.Application.DTOs;
using EGAPI.Bookstore.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EGAPI.Bookstore.Domain.Services
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorDTO>> GetAllAuthors();
        Task<AuthorDTO> GetAuthorByID(int id);
        Task<AuthorDTO> UpdateAuthor(int id, AuthorDTO author);
        Task<AuthorDTO> NewAuthor(AuthorDTO author);
        Task<AuthorDTO> DeleteAuthor(int id);
    }
}