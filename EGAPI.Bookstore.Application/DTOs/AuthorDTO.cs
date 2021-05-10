using EGAPI.Bookstore.Domain.Models;
using AutoMapper;

namespace EGAPI.Bookstore.Application.DTOs
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
