using System.Collections;
using System.Collections.Generic;

namespace BookStore.Models.Repositories
{
    public interface IBookStoreRepository<TEntity> //TEntity Generic implament 
    {
        IList<TEntity> List();
        TEntity Find(int id);
        void Delete(int id);
        void Update(TEntity entity, int bookId);
        void Update(int id, Author author);
        Author Find(string authorId);
        void Update(int bookId, Book book);
        void Update(Book book);
        void Update(Author author);
        void Add(Book book);
    }
}
