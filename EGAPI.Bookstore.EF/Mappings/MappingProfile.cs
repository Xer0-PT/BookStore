using AutoMapper;
using EGAPI.Bookstore.Domain.Models;
using EGAPI.Bookstore.Application.DTOs;

namespace EGAPI.Bookstore.EF.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EGAPI.Bookstore.Domain.Models.Author, EGAPI.Bookstore.Application.DTOs.AuthorDTO>().ReverseMap(); ;
            CreateMap<EGAPI.Bookstore.Application.DTOs.AuthorDTO, EGAPI.Bookstore.Domain.Models.Author>().ReverseMap(); ;
        }
    }
}
