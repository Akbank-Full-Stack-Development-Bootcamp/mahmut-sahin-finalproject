using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repositories
{
    public class UserRepository : IRepository<User>
    {
        public int Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        private List<User> users = new List<User> {
                new User {Email= "mahmut2sahin@gmail.com", Password= "624688", UserName="mahmut", Role="Admin"},
                new User {Email="martin2eden@gmail.com", Password = "123456", UserName = "martin", Role="Editor"}
            };

        public IList<User> GetAll()
        {
            return users;
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<User> GetWithCriteria(Func<User, bool> criteria)
        {
            return users.Where(criteria).ToList();
        }

        public int Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
