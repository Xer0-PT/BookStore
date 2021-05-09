using AutoMapper;
using EGAPI.DTOs;
using EGAPI.Models;

namespace EGAPI.Mappings
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
