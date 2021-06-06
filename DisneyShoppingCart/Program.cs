using System;
using DisneyShoppingCart.Models;
using DisneyShoppingCart.DTOS;
using System.Collections.Generic;
using System.Linq;
using DisneyShoppingCart.Repositories.Implementation;

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
            //string response = "";
            //List<Users> userlist = new List<Users>();
            //List<Comments> commentList = new List<Comments>();

            //while (response!="5")
            //{
            //    Console.WriteLine("1. Create a User");
            //    Console.WriteLine("2. Create a Comment");
            //    Console.WriteLine("3. Print the List of Users");
            //    Console.WriteLine("4. Print the List of Comments");
            //    Console.WriteLine("5. Exit");

            //    Console.WriteLine("");
            //    Console.WriteLine("Please select an option");
            //    response = Console.ReadLine();

            //    switch(response)
            //    {
            //case "1":
            //    Users user = new Users();
            //    user.Email = "myemail@somewhere.com";
            //    user.Password = "password";
            //    user.UserID = 1;
            //    user.UserName = "Kat";

            //    userlist.Add(user);

            //    Console.WriteLine("You have created a user");
            //    break;
            //case "2":
            //    Comments myComment = new Comments();
            //    myComment.CommentId = 1;
            //    myComment.TheComment = "What's up";

            //    commentList.Add(myComment);

            //    Console.WriteLine("You have created a comment");
            //    break;
            //case "3":
            //    Console.WriteLine("This is the list of users created:");

            //    foreach (var insideUser in userlist)
            //    {
            //        Console.WriteLine("The user email is: " + insideUser.Email);
            //        Console.WriteLine("The user password is: " + insideUser.Password);
            //        Console.WriteLine("The user id is: " + insideUser.UserID);
            //        Console.WriteLine("The user name is: " + insideUser.UserName);
            //    }
            //    break;
            //case "4":
            //    Console.WriteLine("This is the list of comments created:");

            //    foreach (var insideComment in commentList)
            //    {
            //        Console.WriteLine("The comment id is: " + insideComment.CommentId);
            //        Console.WriteLine("The actual comment is: " + insideComment.TheComment);
            //    }
            //    break;


            UserRepository userRepo = new UserRepository();
            userRepo.GetAllUsersByName("Kat");

            Users newUsers = new Users();
            newUsers.UserID = 1;
            newUsers.Email = "myemail@somewhere.com";
            newUsers.Password = "password";
            newUsers.UserName = "Kat";

            Users newUsers2 = new Users();
            newUsers2.UserID = 2;
            newUsers2.Email = "theiremail@somewhere.com";
            newUsers2.Password = "password";
            newUsers2.UserName = "Brandon";

            Users newUsers3 = new Users();
            newUsers3.UserID = 3;
            newUsers3.Email = "theyemail@somewhere.com";
            newUsers3.Password = "password";
            newUsers3.UserName = "Athena";

            userRepo.Save(newUsers);
            userRepo.Save(newUsers2);
            userRepo.Save(newUsers3);

            userRepo.GetAllUsersByName();

        }
    }

}
//    }
//}
