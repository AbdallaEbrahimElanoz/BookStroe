using System.Collections;
using System.Collections.Generic;

namespace BookStroe.Models.Repositories
{
    public interface IBookStoreRepository<TEntity> //TEntity Generic implament 
    {
        IList<TEntity> List();
        TEntity FindById(int id);
        void DeleteById(int id);
        void UpdateById(TEntity entity);
        void UpdateById(TEntity entity, int id);
        void Add(TEntity entity);
        void Update(int id, Author author);
    }
}
