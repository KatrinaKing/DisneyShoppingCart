using System;
using System.Collections.Generic;
using System.Linq;
using DisneyShoppingCart.Exceptions;
using DisneyShoppingCart.Models;

namespace DisneyShoppingCart.Repositories.Implementation
{
    public class UserRepository : MainRepository<Users>, IUser_Repository
    {
        private List<Users> currentDatabase;

        public UserRepository() 
        {
            currentDataBase = new List<Users>();
        }

        

        public List<Users> GetAllUsersByName(string UserName)
        {
            List<Users> resultList =
                currentDataBase.Where(Users => Users.UserName == UserName).ToList();

            if (resultList.Count > 0)
            {
                return resultList;
            }
            else
            {
                throw new UserNotFound("No User Found");
            }
        }

        public void GetAllUsersByName()
        {
            Console.WriteLine("Not here");
        }

        public override void Save(Users user)
        {
            user.UserID = currentDataBase.Count + 1;
            currentDataBase.Add(user);
            Console.WriteLine("You added the User");
        }

        public override List<Users> Get()
        {
            return currentDataBase;
        }
    }
    }

