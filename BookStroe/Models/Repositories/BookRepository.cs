using System;
using System.Collections.Generic;

namespace BookStroe.Models.Repositories
{

    public class BookRepository : IBookStoreRepository<Book>
    {
        public void Add(Book entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Book FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Book> List()
        {
            throw new NotImplementedException();
        }

        public void UpdateById(Book entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateById(Book entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
