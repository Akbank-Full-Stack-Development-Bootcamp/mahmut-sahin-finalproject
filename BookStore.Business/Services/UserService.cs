using BookStore.DataAccess.Repositories;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Business.Services
{
    public class UserService
    {
        private readonly UserRepository repository;

        public UserService(UserRepository repository)
        {
            this.repository = repository;
        }

        public User GetUser (string email, string password)
        {
            return repository.GetWithCriteria(x => x.Email == email && x.Password == password).FirstOrDefault();
        }
    }
}
