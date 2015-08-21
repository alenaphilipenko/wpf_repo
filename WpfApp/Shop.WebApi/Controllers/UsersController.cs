using System.Collections.Generic;
using System.Web.Http;
using Shop.WebApi.BL.Interfaces;

namespace Shop.WebApi.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public int ReturnSquare(int id)
        {
            return id * id;
        }
    }
}
