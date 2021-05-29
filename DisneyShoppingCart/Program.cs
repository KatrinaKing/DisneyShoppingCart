using System;
using DisneyShoppingCart.Models;
using DisneyShoppingCart.DTOS;
using System.Collections.Generic;
using System.Linq;

namespace DisneyShoppingCart
{
    class Program
    {
        private static object users;

        static void Main(string[] args)
        {

            Program.MyMethod();
           
        }

        static void MyMethod()
        {

            //try
            //{
            //    List<Users> myList = new List<Users>();

            //    Users firstUser = new Users();
            //    firstUser.UserID = 10;
            //    firstUser.UserName = "P3nnyw1s3";
            //    firstUser.UserType = "Public";
            //    firstUser.UserHobby ="scary Movies";
            //    firstUser.UserState = "Washington";

            //    myList.Add(firstUser);

            //    Users secondUser = new Users();
            //    secondUser.UserID = 9;
            //    secondUser.UserName = "Sakura";
            //    secondUser.UserType = "Private";
            //    secondUser.UserHobby = "Anime";
            //    secondUser.UserState = "Maine";

            //    myList.Add(secondUser);

            //    Users thirdUser = new Users();
            //    thirdUser.UserID = 8;
            //    thirdUser.UserName = "Sunl3ss";
            //    thirdUser.UserType = "Private";
            //    thirdUser.UserHobby = "Gardening";
            //    thirdUser.UserState = "California";

            //    myList.Add(thirdUser);

            //    Users fourthUser = new Users();
            //    fourthUser.UserID = 7;
            //    fourthUser.UserName = "Glu3d2U";
            //    fourthUser.UserType = "Public";
            //    fourthUser.UserHobby = "Crafts";
            //    fourthUser.UserState = "Virginia";

            //    myList.Add(fourthUser);

            //    Users fifthUser = new Users();
            //    fifthUser.UserID = 6;
            //    fifthUser.UserName = "B0bBu1ld3r";
            //    fifthUser.UserType = "Private";
            //    fifthUser.UserHobby = "Carpentry";
            //    fifthUser.UserState = "Arizona";

            //    myList.Add(fifthUser);

            //    Users sixthUser = new Users();
            //    sixthUser.UserID = 5;
            //    sixthUser.UserName = "B00t13$";
            //    sixthUser.UserType = "Public";
            //    sixthUser.UserHobby = "Hiking";
            //    sixthUser.UserState = "Texas";

            //    myList.Add(sixthUser);

            //    Users seventhUser = new Users();
            //    seventhUser.UserID = 4;
            //    seventhUser.UserName = "P1c@$$0";
            //    seventhUser.UserType = "Public";
            //    seventhUser.UserHobby = "Painting";
            //    seventhUser.UserState = "Florida";

            //    myList.Add(seventhUser);

            //    Users eighthUser = new Users();
            //    eighthUser.UserID = 3;
            //    eighthUser.UserName = "Th0u$@ndl1ve$";
            //    eighthUser.UserType = "Private";
            //    eighthUser.UserHobby = "Reading";
            //    eighthUser.UserState = "Georgia";

            //    myList.Add(eighthUser);

            //    Users ninthUser = new Users();
            //    ninthUser.UserID = 2;
            //    ninthUser.UserName = "foosb@ll3r";
            //    ninthUser.UserType = "Public";
            //    ninthUser.UserHobby = "Football";
            //    ninthUser.UserState = "New York";

            //    myList.Add(ninthUser);

            //    Users tenthUser = new Users();
            //    tenthUser.UserID = 1;
            //    tenthUser.UserName = "SkadrGrl";
            //    tenthUser.UserType = "Private";
            //    tenthUser.UserHobby = "Skateboards";
            //    tenthUser.UserState = "Oregon";

            //    myList.Add(tenthUser);


            //    List<Users> result = myList.Where(users => users.UserID == 1).ToList();

            //    if(result.Count == 0)
            //    {
            //        throw new UserNotFound("This user does not exist in this list of users");
            //    }
            //    else
            //    {
            //        foreach (var users in result)
            //        {
            //            Console.WriteLine(users.UserID);
            //            Console.WriteLine(users.UserName);
            //            Console.WriteLine(users.UserType);
            //            Console.WriteLine(users.UserHobby);
            //            Console.WriteLine(users.UserState);
            //        }
            //    }
            //}

            //catch (UserNotFound exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}
            //finally
            //{

            //}


            NewClass<string,bool,int> myNewClass = new NewClass<string,bool,int>();
            myNewClass.GenericProperty = "My generic string";
            myNewClass.GenericProperty2 = true;
            myNewClass.GenericProperty3 = 100204;

            Console.WriteLine(myNewClass.GenericProperty);
            Console.WriteLine(myNewClass.GenericProperty2);
            Console.WriteLine(myNewClass.GenericProperty3);



            //Users usersObject = new Users("SunnyDLight", "YouAreNotTheWay");

            //string stringFormat = "My influencer name is {0} and my regular username is {1}.";

            //Console.WriteLine(String.Format(stringFormat, usersObject.privateUserName, usersObject.publicUserName));

            //UsersDTO newDTOUser = new UsersDTO();
            //newDTOUser.privateUserName = "BobEsponja";
            //newDTOUser.publicUserName = "LipBalm";

            //String newstringFormat = "My new influencer name is {0} and my new reg username is {1}.";

            //Console.WriteLine(String.Format(newstringFormat, newDTOUser.privateUserName, newDTOUser.publicUserName));



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


            //int[] myArray = new int[] {1,2,3,4,5};

            //Console.WriteLine("The array has " + myArray.Length);

            //List<int> myList = new List<int>();

            //myList.Add(0);
            //myList.Add(1);
            //myList.Add(2);
            //myList.Add(3);
            //myList.Add(4);
            //myList.Add(5);
            //myList.Add(6);
            //myList.Add(7);
            //myList.Add(8);
            //myList.Add(9);
            //myList.Add(10);

            // foreach(var item in myList)
            //{
            //    Console.Write(item + ",");
            //}
        }
    }
}

//public class UserNotFound : Exception
//{
//    public UserNotFound(string errorMessage) : base(errorMessage)
//    {

//    }
//}


public class NewClass<T, K, B>
{
    public T GenericProperty { get; set; }
    public K GenericProperty2 { get; set; }
    public B GenericProperty3 { get; set; }
}