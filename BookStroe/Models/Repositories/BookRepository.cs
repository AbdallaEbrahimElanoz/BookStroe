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
                Id = 1, title="C#" ,Description="lrean C#",ImageUrl ="zae.jpeg",Author = new Author{Id =2 }
                },
                 new Book() {
                Id = 2, title="f#" ,Description="lrean f#",ImageUrl ="images (2).png",Author = new Author()
                },
                  new Book() {
                Id = 3, title="C" ,Description="lrean C",ImageUrl ="b#.png",Author = new Author()
                },
                   new Book() {
                Id = 4, title="C++" ,Description="lrean C++",ImageUrl = "m#.png", Author = new Author()
                },
                    new Book() {
                Id = 5, title="Css" ,Description="lrean Css",ImageUrl ="angular.png",  Author = new Author()
                },
            };
        }
        public void Add(Book entity)
        {
            entity.Id = books.Max(x => x.Id) + 1;
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

        public void Update(int id,Book newBook)
        {
            var book = Find(id); 
            book.title =newBook.title;
            book.Description=newBook.Description;
            book.ImageUrl = newBook.ImageUrl;
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

        public List<Book> Search(string term)
        {
            return books.Where(a => a.title.Contains(term)).ToList();
        }
    }
}
