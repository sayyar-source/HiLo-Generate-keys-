using HiLoAlgorithm.Model.Models;
using HiLoAlgorithm.Service.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HiLoAlgorithm.Service.Service
{
    public class UserService : IUserRepository
    {
        private readonly HiLoContext _db;
        public UserService(HiLoContext db)
        {
            _db = db;
        }
        public int AddUser(User user)
        {
            var result = _db.Users.Add(user);
            _db.SaveChangesAsync();
            return result.Entity.ID;
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
