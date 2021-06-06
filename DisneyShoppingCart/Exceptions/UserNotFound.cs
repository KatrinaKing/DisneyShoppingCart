using System;
namespace DisneyShoppingCart.Exceptions
{
    public class UserNotFound : Exception
    { 
        public UserNotFound(string errorMessage) :base(errorMessage)
        {
        }
    }
}
