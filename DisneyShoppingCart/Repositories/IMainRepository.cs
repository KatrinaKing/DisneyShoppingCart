using System;
namespace DisneyShoppingCart.Repositories
{
    public interface IMainRepository<T>
    {
        public void Save(T entity);

        public void Update(T entity);

        public void Delete(T entity);

    }
}
