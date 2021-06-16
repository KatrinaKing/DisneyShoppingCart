using System;
using System.Collections.Generic;
using DisneyShoppingCart.Models;

namespace DisneyShoppingCart.Repositories
{
    public interface IComment_Repository
    {
        public List<Comments> GetCommentsByComment(string comment);
    }
}
