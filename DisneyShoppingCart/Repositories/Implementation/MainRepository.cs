using System;
using System.Collections.Generic;

namespace DisneyShoppingCart.Repositories.Implementation
{
    public class MainRepository<T> : IMainRepository<T>
    {
        public List<T> currentDataBase = new List<T>();

        public MainRepository()
        {
        }

        public void Delete(T User)
        {
            currentDataBase.Remove(User);
            Console.WriteLine("You deleted the User");
        }

        public void Save(T User)
        {
            currentDataBase.Add(User);
            Console.WriteLine("You saved the User");
        }

        public void Update(T User)
        {
            Console.WriteLine("You updated the User");
        }


    }

}