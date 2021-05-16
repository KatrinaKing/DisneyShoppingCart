using System;
namespace DisneyShoppingCart.Models
{
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
}
