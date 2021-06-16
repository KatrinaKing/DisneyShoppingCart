using System;
using System.Collections.Generic;
using DisneyShoppingCart.Models;

namespace DisneyShoppingCart.Repositories.Implementation
{
    public abstract class MainRepository<T> : IMainRepository<T>
    {
        public List<T> currentDataBase = new List<T>();

        public void Delete(T User)
        {
            currentDataBase.Remove(User);
            Console.WriteLine("You deleted the User");
        }

        public abstract void Save(T User);

        public void Update(T User)
        {
            Console.WriteLine("You updated the User");
        }

        public abstract List<T> Get();

    }

}