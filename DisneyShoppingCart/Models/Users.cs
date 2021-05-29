using System;
namespace DisneyShoppingCart.Models
{
    public class Users
    {
        //public string privateUserName { get; set; }
        //public string publicUserName { get; set; }

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public string UserHobby { get; set; }
        public string UserState { get; set; }

        //public Users(string newPrivateUserName, string newPublicUserName)
        //{
        //    this.privateUserName = newPrivateUserName;
        //    this.publicUserName = newPublicUserName;
        //}
    }
}
