using BookStore.Models.Repositories;
using BookStore.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace BookStroe.Models.Repositories
{
    public class BookDbRepository : IBookStoreRepository<Book>
    {
        BookstoreDbContext db;
        public BookDbRepository(BookstoreDbContext db)
        {
            this.db = db;
        }
        public void Add(Book entity)
        {
            db.Books.Add(entity);
            db.SaveChanges();
        }
        public Book Find(int id)
        {
            var book = db.Books.SingleOrDefault(x => x.Id == id);
            return book;
        }


        public void Delete(int id)
        {
            var book = Find(id);
            db.Books.Remove(book);
            db.SaveChanges();
        }


        public IList<Book> List()
        {
            return db.Books.ToList();
        }

        public void UpdateById(Book entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Book newBook)
        {
            db.Books.Update(newBook);
            db.SaveChanges();


        }

        public void Update(int id, Author author)
        {
            throw new NotImplementedException();
        }

        public Author Find(string authorId)
        {
            throw new NotImplementedException();
        }



        public void Update(Author author)
        {
            throw new NotImplementedException();
        }

        public void ViewModel(Book book)
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

        public void Update(Book entity, int bookId)
        {
            throw new NotImplementedException();
        }
    }
}

