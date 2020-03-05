using HiLoAlgorithm.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HiLoAlgorithm.Service.Repository
{
   public interface IUserRepository
    {
         int AddUser(User user);
        User GetById(int Id);
        List<User> GetAll();
    }
}
