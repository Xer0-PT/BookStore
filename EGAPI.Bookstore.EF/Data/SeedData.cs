using System.Linq;

namespace EGAPI.Bookstore.EF.Data
{
    public class SeedData
    {
        public static void Initialize(DataContext context)
        {
            if(!context.Authors.Any())
            {
                context.Authors.AddRange(
                    new Domain.Models.Author
                    {
                        Id = 1,
                        FirstName = "José",
                        LastName = "Saramago"
                    },
                    new Domain.Models.Author
                    {
                        Id = 2,
                        FirstName = "Fernando",
                        LastName = "Pessoa"
                    }
                    /*
                    new Author
                    {
                        Id = 1,
                        FirstName = "José",
                        LastName = "Saramago"
                    },

                    new Models.Author
                    {
                        Id = 2,
                        FirstName = "Fernando",
                        LastName = "Pessoa"
                    }
                    */
                    );

                context.SaveChanges();
            }

            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    new Domain.Models.Book
                    {
                        Id = 1,
                        Title = "Memorial do Convento",
                        CategoriyId = 1,
                        AuthorId = 1
                    },
                    new Domain.Models.Book
                    {
                        Id = 2,
                        Title = "Livro do Desassossego",
                        CategoriyId = 1,
                        AuthorId = 2
                    }/*
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
                    }*/
                    );

                context.SaveChanges();
            }

            if(!context.Categories.Any())
            {
                context.Categories.Add(
                    new Domain.Models.Category
                    {
                        Id = 1,
                        Name = "Romance"
                    }/*
                    new Models.Category
                    {
                        Id = 1,
                        Name = "Romance"
                    }*/
                    );

                context.SaveChanges();
            }
        }
    }
}
