using Shop.WebApi.DAL.Repositoties;
using SimpleInjector;

namespace Shop.WebApi.DAL
{
    public class DataAccessLayerPackage
    {
        public static void RegisterServices(Container container)
        {
            container.Register<IUserRepository, UserRepository>();
        }
    }
}
