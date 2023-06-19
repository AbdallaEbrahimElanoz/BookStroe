using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Models.Repositories
{

    public class BookRepository : IBookStoreRepository<Book>
    {
        List<Book> books;
        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book() {
                Id = 1, title="C#" ,Description="lrean C#",Author = new Author{Id =2 }
                },
                 new Book() {
                Id = 2, title="f#" ,Description="lrean f#",Author = new Author()
                },
                  new Book() {
                Id = 3, title="C" ,Description="lrean C",Author = new Author()
                },
                   new Book() {
                Id = 4, title="C++" ,Description="lrean C++",Author = new Author()
                },
                    new Book() {
                Id = 5, title="Css" ,Description="lrean Css",  Author = new Author()
                },
            };
        }
        public void Update(Book entity)
        {
            books.Add(entity);
        }
        public Book Find(int id)
        {
            var book = books.SingleOrDefault(x => x.Id == id);
            return book;
        }


        public void Delete(int id)
        {
            var book = Find(id);  
            books.Remove(book);
        }

        
        public IList<Book> List()
        {
            return books;
        }

        public void UpdateById(Book entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Book newBook, int id)
        {
            var book = Find(id); 
            book.title =newBook.title;
            book.Description=newBook.Description;
            book.Author = newBook.Author;

        }

        public void Update(int id, Author author)
        {
            throw new NotImplementedException();
        }

        public Author Find(string authorId)
        {
            throw new NotImplementedException();
        }

        public void Update(int bookId, Book book)
        {
            throw new NotImplementedException();
        }

        public void Update(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
