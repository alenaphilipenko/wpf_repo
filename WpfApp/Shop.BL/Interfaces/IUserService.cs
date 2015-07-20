using System.Collections.Generic;

namespace Shop.WebApi.BL.Interfaces
{
    public interface IUserService
    {
        IEnumerable<string> GetUserTelephones(int userId);
    }
}
