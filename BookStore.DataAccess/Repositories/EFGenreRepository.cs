using BookStore.DataAccess.Data;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repositories
{
    public class EFGenreRepository : IGenreRepository
    {
        private readonly BookStoreDbContext db;

        public EFGenreRepository(BookStoreDbContext db)
        {
            this.db = db;
        }

        public int Add(Genre entity)
        {
            db.Genres.Add(entity);
            db.SaveChanges();
            return entity.Id;
        }
        public Genre GetById(int id)
        {
            var result = db.Genres.FirstOrDefault(g => g.Id == id);
            return result;
        }


        public IList<Genre> GetAll()
        {
            var result = db.Genres.ToList();
            return result;
        }


        public IList<Genre> GetWithCriteria(Func<Genre, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public int Update(Genre entity)
        {
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return entity.Id;
        }

        public void Delete(int id)
        {
            db.Remove(GetById(id));
            db.SaveChanges();
        }
    }
}
