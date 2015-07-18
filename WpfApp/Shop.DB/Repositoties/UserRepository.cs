using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Cfg;
using Shop.DB.Entities;
using Shop.DB.Repositoties;

namespace Shop.WebApi.DAL.Repositoties
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private Configuration myConfiguration;
        private ISessionFactory mySessionFactory;
        private ISession mySession;

        public UserRepository()
        {
            myConfiguration = new Configuration();
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();
        }

        public IEnumerable<Phone> GetUserTelephones(int id)
        {
            var userId = mySession.Get<User>(id).Id;
            return mySession.CreateCriteria<Phone>().List<Phone>().Where(p => p.Owner == userId);
        }
    }
}
