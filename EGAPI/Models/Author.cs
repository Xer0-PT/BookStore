using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EGAPI.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        List<Book> Books = new List<Book>();

    }
}
