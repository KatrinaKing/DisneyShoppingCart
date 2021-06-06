﻿using System;
using System.Collections.Generic;
using System.Linq;
using DisneyShoppingCart.Exceptions;
using DisneyShoppingCart.Models;

namespace DisneyShoppingCart.Repositories.Implementation
{
    public class UserRepository : MainRepository<Users>, IUser_Repository
    {
        public UserRepository() 
        {
        }

        public void GetAllUsersByName()
        {
            List<Users> resultList =
                currentDataBase.Where(Users => Users.UserName == "UserName").ToList();

            if (resultList.Count > 0)
            {
                foreach(var newUsers in resultList)
                {
                    Console.WriteLine(newUsers.UserID);
                    Console.WriteLine(newUsers.UserName);
                    Console.WriteLine(newUsers.Email);
                }
            }
            else
            {
                Console.WriteLine("No UserName found");
            }
        }

        public void GetAllUsersByName(string name)
        {
            Console.WriteLine("Not here");
        }
    }
    }
