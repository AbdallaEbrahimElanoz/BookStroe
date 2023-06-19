using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Models.Repositories
{
    public class AuthorRepository : IBookStoreRepository<Author>
    {
        IList<Author> authors;
        public AuthorRepository() {
            authors = new List<Author>()
            {
                new Author()
                {
                    Id = 1,FullName="Abdullah e"
                },
                 new Author()
                {
                    Id = 2,FullName="Abdullah a"
                },
                  new Author()
                {
                    Id = 3,FullName="Abdullah c"
                },
                   new Author()
                {
                    Id = 4,FullName="Abdullah d"
                },
            };



        }
        public void Add(Author entity)
        {
            authors.Add(entity);    
        }

        public void Delete(int id)
        {
            var author = Find(id);
            authors.Remove(author);
        }

 
        public Author Find(int id)
        {
           var author=authors.SingleOrDefault(x => x.Id == id);
            return author;
        }

        public Author Find(string authorId)
        {
            throw new NotImplementedException();
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void Update(int id, Author newAuthor)
        {
            var author = Find(id);
            author.FullName = newAuthor.FullName;
        }

        public void Update(Author entity, int bookId)
        {
            throw new NotImplementedException();
        }

        public void Update(int bookId, Book book)
        {
            throw new NotImplementedException();
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }

        public void Update(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
