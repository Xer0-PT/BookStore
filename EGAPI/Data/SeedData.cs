using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EGAPI.Data
{
    public class SeedData
    {
        public static void Initialize(DataContext context)
        {
            if(!context.Authors.Any())
            {
                context.Authors.AddRange(
                    new Models.Author
                    {
                        Id = 1,
                        Name = "José",
                        LastName = "Saramago"
                    },

                    new Models.Author
                    {
                        Id = 2,
                        Name = "Fernando",
                        LastName = "Pessoa"
                    }
                    );

                context.SaveChanges();
            }

            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    new Models.Book
                    {
                        Id = 1,
                        Title = "Memorial do Convento",
                        CategoriyId = 1,
                        AuthorId = 1
                    },

                    new Models.Book
                    {
                        Id = 2,
                        Title = "Livro do Desassossego",
                        CategoriyId = 1,
                        AuthorId = 2
                    }
                    );

                context.SaveChanges();
            }

            if(!context.Categories.Any())
            {
                context.Categories.Add(
                    new Models.Category
                    {
                        Id = 1,
                        Name = "Romance"
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
