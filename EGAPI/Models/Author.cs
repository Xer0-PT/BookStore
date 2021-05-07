using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EGAPI.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set;}
    }
}
