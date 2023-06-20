using BookStore.Models.Repositories;
using BookStore.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace BookStroe.Models.Repositories
{
    public class AuthorDbRepository : IBookStoreRepository<Author>
    {
        BookstoreDbContext db;
        public AuthorDbRepository(BookstoreDbContext _db)
        {
            db = _db;
        }
        public void Add(Author entity)
        {
            db.Authors.Add(entity);
        }

        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var author = Find(id);
            db.Authors.Remove(author);
        }


        public Author Find(int id)
        {
            var author = db.Authors.SingleOrDefault(x => x.Id == id);
            return author;
        }

        public Author Find(string authorId)
        {
            throw new NotImplementedException();
        }

        public IList<Author> List()
        {
            return Authors;
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

        public void ViewModel(Book book)
        {
            throw new NotImplementedException();
        }

        public void Update(Author author)
        {
            throw new NotImplementedException();
        }

        public void viewModel(Book book)
        {
            throw new NotImplementedException();
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
