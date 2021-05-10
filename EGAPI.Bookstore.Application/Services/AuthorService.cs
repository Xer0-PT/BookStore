using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using EGAPI.Bookstore.Application.DTOs;
using EGAPI.Bookstore.EF.Repos;
using EGAPI.Bookstore.Domain.Models;

namespace EGAPI.Bookstore.Application.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepo _authorRepo;
        private readonly IMapper _mapper;

        public AuthorService(IAuthorRepo authorRepo, IMapper mapper)
        {
            _authorRepo = authorRepo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AuthorDTO>> GetAllAuthors()
        {
            var authors = await _authorRepo.GetAllAuthors();

            var dto = _mapper.Map<IEnumerable<AuthorDTO>>(authors);

            return dto;
        }

        public async Task<AuthorDTO> GetAuthorByID(int id)
        {
            var author = await _authorRepo.GetAuthorByID(id);

            var dto = _mapper.Map<AuthorDTO>(author);

            return dto;
        }

        public async Task<AuthorDTO> UpdateAuthor(int id, AuthorDTO author)
        {
            var authorDTO = _mapper.Map<Author>(author);

            var put = await _authorRepo.UpdateAuthor(id, authorDTO);

            var dto = _mapper.Map<AuthorDTO>(put);

            return dto;
        }

        public async Task<AuthorDTO> NewAuthor(AuthorDTO author)
        {
            var authorDTO = _mapper.Map<Author>(author);

            var newAuthor = await _authorRepo.NewAuthor(authorDTO);

            var dto = _mapper.Map<AuthorDTO>(newAuthor);

            return dto;
        }

        public async Task<AuthorDTO> DeleteAuthor(int id)
        {
            var author = await _authorRepo.DeleteAuthor(id);

            var dto = _mapper.Map<AuthorDTO>(author);

            return dto;
        }

    }
}
