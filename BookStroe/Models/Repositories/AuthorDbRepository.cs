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
            db.SaveChanges();
        }

        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var author = Find(id);
            db.Authors.Remove(author);
            db.SaveChanges();
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
            return db.Authors.ToList();
        }

        public List<Author> Search(string term)
        {
            return db.Authors.Where(a => a.FullName.Contains(term)).ToList();
        }

        public void Update(int id, Author newAuthor)
        {
            db.Update(newAuthor);
            db.SaveChanges();
        }

        List<Author> IBookStoreRepository<Author>.Search(string term)
        {
            throw new NotImplementedException();
        }
    }
}
