using System;
using DisneyShoppingCart.Models;
using DisneyShoppingCart.DTOS;

namespace DisneyShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {

            Program.MyMethod();
           
        }

        static void MyMethod()
        {
            /*Users usersObject = new Users("SunnyDLight", "YouAreNotTheWay");

            string stringFormat = "My influencer name is {0} and my regular username is {1}.";

            Console.WriteLine(String.Format(stringFormat, usersObject.privateUserName, usersObject.publicUserName));

            UsersDTO newDTOUser = new UsersDTO();
            newDTOUser.privateUserName = "BobEsponja";
            newDTOUser.publicUserName = "LipBalm";

            String newstringFormat = "My new influencer name is {0} and my new reg username is {1}.";

            Console.WriteLine(String.Format(newstringFormat, newDTOUser.privateUserName, newDTOUser.publicUserName));*/



            DateTime myDateTimeVariable1 = new DateTime(2004,10,04);
            DateTime myDateTimeVariable2 = new DateTime(1987,01,16);


             if (myDateTimeVariable1 < myDateTimeVariable2)
            {
                Console.WriteLine("Yes, it is less!");
            }
             else
            {
                Console.WriteLine("No, it is greater!");
            }
        }
    }
}
