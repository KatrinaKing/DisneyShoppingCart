using System;

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
            Users usersObject = new Users("SunnyDLight", "YouAreNotTheWay");

            string stringFormat = "My influencer name is {0} and my regular user name is {1}.";

            Console.WriteLine(String.Format(stringFormat, usersObject.privateUserName, usersObject.publicUserName));
        }
    }

    public class Users
    {
        public string privateUserName { get; set; }
        public string publicUserName { get; set; }

        public Users(string newPrivateUserName, string newPublicUserName)
        {
            this.privateUserName = newPrivateUserName;
            this.publicUserName = newPublicUserName;
        }
    }

    public class Roles
    {
        public string influencer { get; set; }
        public string regUser { get; set; }

        public Roles(string newPrivateUserName, string newPublicUserName)
        {
            this.influencer = newPrivateUserName;
            this.regUser = newPublicUserName;
        }
    }

    public class Images
    {
        public string publicImages { get; set; }
        public string privateImages { get; set; }

        public Images(string newPrivateUserName, string newPublicUserName)
        {
            this.publicImages = newPrivateUserName;
            this.privateImages = newPublicUserName;
        }
    }

    public class Posts
    {
        public string privatePosts { get; set; }
        public string publicPosts { get; set; }

        public Posts(string newPrivateUserName, string newPublicUserName)
        {
            this.privatePosts = newPrivateUserName;
            this.publicPosts = newPublicUserName;
        }
    }

    public class Comments
    {
        public string privateComments { get; set; }
        public string publicComments { get; set; }

        public Comments(string newPrivateUserName, string newPublicUserName)
        {
            this.privateComments = newPrivateUserName;
            this.publicComments = newPublicUserName;
        }
    }
}
