using System;
using DisneyShoppingCart.Models;

namespace DisneyShoppingCart.Repositories
{
    public interface IUser_Repository : IMainRepository<Users>
    {
        public void GetAllUsersByName(string name);
    }
}
