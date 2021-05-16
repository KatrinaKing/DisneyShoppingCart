using System;
namespace DisneyShoppingCart.Models
{
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
