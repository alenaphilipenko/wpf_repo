using Shop.WebApi.BL.Interfaces;
using SimpleInjector;

namespace Shop.WebApi.BL
{
    public class BusinessLayerPackage
    {
        public static void RegisterServices(Container container)
        {
            container.Register<IUserService, UserService>();
        }
    }
}
