using System;
using DisneyShoppingCart.Models;
using DisneyShoppingCart.DTOS;
using System.Collections.Generic;

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
            ///*Users usersObject = new Users("SunnyDLight", "YouAreNotTheWay");

            //string stringFormat = "My influencer name is {0} and my regular username is {1}.";

            //Console.WriteLine(String.Format(stringFormat, usersObject.privateUserName, usersObject.publicUserName));

            //UsersDTO newDTOUser = new UsersDTO();
            //newDTOUser.privateUserName = "BobEsponja";
            //newDTOUser.publicUserName = "LipBalm";

            //String newstringFormat = "My new influencer name is {0} and my new reg username is {1}.";

            //Console.WriteLine(String.Format(newstringFormat, newDTOUser.privateUserName, newDTOUser.publicUserName));*/



            //DateTime myDateTimeVariable1 = new DateTime(2004,10,04);
            //DateTime myDateTimeVariable2 = new DateTime(1987,01,16);


            // if (myDateTimeVariable1 < myDateTimeVariable2)
            //{
            //    Console.WriteLine("Yes, it is less!");
            //}
            // else
            //{
            //    Console.WriteLine("No, it is greater!");
            //}


            // int loopVal;
            // int end_value = 21;
            // int addition = 0;

            // for (loopVal = 1; loopVal < end_value; loopVal++)
            // {
            //     addition = addition + loopVal;
            // }
            // {
            //     Console.WriteLine("Total = " + addition);
            // }


            int[] myArray = new int[] {1,2,3,4,5};

            Console.WriteLine("The array has " + myArray.Length);

            List<int> myList = new List<int>();

            myList.Add(0);
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            myList.Add(9);
            myList.Add(10);

             foreach(var item in myList)
            {
                Console.Write(item + ",");
            }
        }
    }
}
