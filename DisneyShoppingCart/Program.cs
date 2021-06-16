using System;
using DisneyShoppingCart.Models;
using DisneyShoppingCart.DTOS;
using System.Collections.Generic;
using DisneyShoppingCart.Repositories.Implementation;
using DisneyShoppingCart.FileManager;

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
            FileManagerClass fm = new FileManagerClass();
            List<Users> userlist = new List<Users>();
            List<Comments> commentList = new List<Comments>();
            Users user = new Users();

            UserRepository userRepo = new UserRepository();
            CommentRepository commentRepo = new CommentRepository();

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

            var response = "";

            while (response != "8")
            {
                Console.WriteLine("1. Create a User");
                Console.WriteLine("2. Create a Comment");
                Console.WriteLine("3. Print the List of Users");
                Console.WriteLine("4. Print the List of Comments");
                Console.WriteLine("5. Look for a User");
                Console.WriteLine("6. Look for a Comment");
                Console.WriteLine("7. Create a Data File");
                Console.WriteLine("8. Exit");

                Console.WriteLine("");
                Console.WriteLine("Please select an option");
                response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        user = new Users();
                        Console.WriteLine("Enter your email");
                        user.Email = Console.ReadLine();
                        Console.WriteLine("Enter your Username");
                        user.UserName = Console.ReadLine();
                        Console.WriteLine("Enter your password");
                        user.Password = Console.ReadLine();
                        userRepo.Save(user);

                        //Console.WriteLine("You have created a user");
                        break;
                    case "2":
                        Comments myComment = new Comments();
                        Console.WriteLine("Enter your comment");
                        myComment.TheComment = Console.ReadLine();


                        commentRepo.Save(myComment);

                        Console.WriteLine("You have created a comment");
                        break;
                    case "3":
                        Console.WriteLine("This is the list of users created:");

                        userlist = userRepo.Get();

                        foreach (Users userX in userlist)
                        {
                            Console.WriteLine("The user email is: " + userX.Email);
                            Console.WriteLine("The user password is: " + userX.Password);
                            Console.WriteLine("The user id is: " + userX.UserID);
                            Console.WriteLine("The user name is: " + userX.UserName);
                            Console.WriteLine("");
                        }
                        break;
                    case "4":
                        Console.WriteLine("This is the list of comments created:");

                        commentList = commentRepo.Get();

                        foreach (var insideComment in commentList)
                        {
                            Console.WriteLine("The comment id is: " + insideComment.CommentId);
                            Console.WriteLine("The actual comment is: " + insideComment.TheComment);
                        }
                        break;
                    case "5":
                        Console.WriteLine("Type username");
                        userlist = userRepo.GetAllUsersByName(Console.ReadLine());
                        foreach (var eachUser in userlist)
                        {
                            Console.WriteLine("The user email is: " + eachUser.Email);
                            Console.WriteLine("The user password is: " + eachUser.Password);
                            Console.WriteLine("The user id is: " + eachUser.UserID);
                            Console.WriteLine("The user name is: " + eachUser.UserName);
                            Console.WriteLine("");
                        }
                        break;
                    case "6":
                        Console.WriteLine("Type your Comment");
                        commentList = commentRepo.GetCommentsByComment(Console.ReadLine());
                        foreach (var eachComment in commentList)
                        {
                            Console.WriteLine("The comment id is: " + eachComment.CommentId);
                            Console.WriteLine("The actual comment is: " + eachComment.TheComment);
                            Console.WriteLine("");
                        }
                        break;
                    case "7":
                        Console.WriteLine("PLease wait for file");
                        userlist = userRepo.Get();
                        commentList = commentRepo.Get();

                        fm.AddInfoToFile("File1.txt", userlist, commentList);
                        break;
                }
            }

        }
    }
}
