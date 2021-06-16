using System;
using System.Collections.Generic;
using System.Linq;
using DisneyShoppingCart.Models;
using DisneyShoppingCart.Exceptions;

namespace DisneyShoppingCart.Repositories.Implementation
{
    public class CommentRepository : MainRepository<Comments>, IComment_Repository
    {

        public CommentRepository()
        {
            currentDataBase = new List<Comments>();
        }

        public override List<Comments> Get()
        {
            return currentDataBase;
        }

        public override void Save(Comments comment)
        {
            comment.CommentId = currentDataBase.Count;
            currentDataBase.Add(comment);
        }

        public List<Comments> GetCommentsByComment(string comment)
        {
            List<Comments> resultList =
                currentDataBase.Where(Comments => Comments.TheComment == comment).ToList();

            if (resultList.Count > 0)
            {
                return resultList;
            }
            else
            {
                throw new CommentNotFound("No comment Found");
            }
        }
    }
}
