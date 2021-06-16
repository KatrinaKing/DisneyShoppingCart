using System;
using DisneyShoppingCart.Models;
using System.Collections.Generic;

namespace DisneyShoppingCart.Repositories
{
    public interface IUser_Repository : IMainRepository<Users>
    {
        public List<Users> GetAllUsersByName(string name);
    }
}
