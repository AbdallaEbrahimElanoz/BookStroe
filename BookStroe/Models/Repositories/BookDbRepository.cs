using BookStore.Models.Repositories;
using BookStore.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            var book = db.Books.Include(a => a.Author).SingleOrDefault(x => x.Id == id);
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
            return db.Books.Include(a=>a.Author).ToList();
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

     
    }
}

