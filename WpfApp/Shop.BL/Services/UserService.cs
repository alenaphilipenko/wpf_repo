using System.Collections.Generic;
using Shop.WebApi.BL.Interfaces;
using Shop.WebApi.DAL.Repositoties;

namespace Shop.WebApi.BL
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository )
        {
            _userRepository = userRepository;
        }

        public IEnumerable<string> GetUserTelephones(int userId)
        {
            return null;
        }
    }
}
