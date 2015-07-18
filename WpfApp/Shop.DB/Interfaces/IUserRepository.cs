using System.Collections.Generic;
using Shop.DB.Entities;

namespace Shop.WebApi.DAL.Repositoties
{
    public interface IUserRepository
    {
        void Add(User entity);
        void Delete(User entity);
        void Update(User entity);
        User FindById(int id);
        IEnumerable<Phone> GetUserTelephones(int id);
    }
}
