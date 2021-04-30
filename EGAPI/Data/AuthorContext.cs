using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EGAPI.Models;

namespace EGAPI.Data
{
    public class AuthorContext : DbContext
    {
        public AuthorContext(DbContextOptions<AuthorContext> options)
            : base(options)
        { }

        public DbSet<Author> Authors { get; set; }
    }
}
