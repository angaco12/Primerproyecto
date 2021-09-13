using System;
using System.Collections.Generic;
using AspNetCoreWebAPI.Infrastructure.Models;

namespace AspNetCoreWebAPI.Interface
{
    public interface IUserRepository
    {
        List<User> GetUsers ();
        void AddUser (User user);

        void UpdateUser (User user);

        void DeleteUser(User user);

    }
}