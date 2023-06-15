using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStroe.Models.Repositories
{
    public class AuthorRepository : IBookStoreRepository<Author>
    {
        IList<Author> authors;
        public AuthorRepository() {
            authors = new List<Author>()
            {
                new Author()
                {
                    Id = 1,FullName="Abdullah"
                },
                 new Author()
                {
                    Id = 1,FullName="Abdullah"
                },
                  new Author()
                {
                    Id = 1,FullName="Abdullah"
                },
                   new Author()
                {
                    Id = 1,FullName="Abdullah"
                },
            };



        }
        public void Add(Author entity)
        {
            authors.Add(entity);    
        }

        public void DeleteById(int id)
        {
            var author = FindById(id);
            authors.Remove(author);
        }

        public Author FindById(int id)
        {
           var author=authors.SingleOrDefault(x => x.Id == id);
            return author;
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void UpdateById(Author entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateById(Author newAuthor, int id)
        {
            var author = FindById(id);
            author.FullName = newAuthor.FullName;
        }
    }
}
