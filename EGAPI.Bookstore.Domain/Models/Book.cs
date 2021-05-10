using System.ComponentModel.DataAnnotations;

namespace EGAPI.Bookstore.Domain.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int CategoriyId { get; set; }

    }
}
