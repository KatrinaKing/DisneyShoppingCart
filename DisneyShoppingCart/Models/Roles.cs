using System;
namespace DisneyShoppingCart.Models
{
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
}
