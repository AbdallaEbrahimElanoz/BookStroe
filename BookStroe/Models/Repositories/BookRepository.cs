using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStroe.Models.Repositories
{

    public class BookRepository : IBookStoreRepository<Book>
    {
        List<Book> books;
        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book() {
                Id = 1, title="C#" ,Description="lrean C#"
                },
                 new Book() {
                Id = 1, title="f#" ,Description="lrean f#"
                },
                  new Book() {
                Id = 1, title="C" ,Description="lrean C"
                },
                   new Book() {
                Id = 1, title="C++" ,Description="lrean C++"
                },
                    new Book() {
                Id = 1, title="Css" ,Description="lrean Css"
                },
            };
        }
        public void Add(Book entity)
        {
            books.Add(entity);
        }
        public Book FindById(int id)
        {
            var book = books.SingleOrDefault(x => x.Id == id);
            return book;
        }


        public void DeleteById(int id)
        {
            var book = FindById(id);  
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

        public void UpdateById(Book newBook, int id)
        {
            var book = FindById(id); 
            book.title =newBook.title;
            book.Description=newBook.Description;
            book.Author = newBook.Author;

        }
    }
}
