using AutoMapper;
using EGAPI.Bookstore.Domain.Models;
using EGAPI.Bookstore.Application.DTOs;

namespace EGAPI.Bookstore.EF.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Author, AuthorDTO>();
            CreateMap<AuthorDTO, Author>();
        }
    }
}
