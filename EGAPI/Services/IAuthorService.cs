using EGAPI.DTOs;
using EGAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EGAPI.Services
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