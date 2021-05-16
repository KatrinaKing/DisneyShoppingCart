using System;
namespace DisneyShoppingCart.Models
{
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
}
