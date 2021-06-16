using System;
namespace DisneyShoppingCart.Exceptions
{
    public class CommentNotFound : Exception
    {
        public CommentNotFound(string errorMessage) : base(errorMessage)
        {
        }
    }
}
