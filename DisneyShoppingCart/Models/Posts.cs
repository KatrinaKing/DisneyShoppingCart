using System;
namespace DisneyShoppingCart.Models
{
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
}
