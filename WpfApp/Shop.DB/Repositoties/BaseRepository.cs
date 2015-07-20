using NHibernate;
using NHibernate.Cfg;
using Shop.DB.Interfaces;

namespace Shop.DB.Repositoties
{
    public class BaseRepository<T> where T : IEntity
    {
        private Configuration myConfiguration;
        private ISessionFactory mySessionFactory;
        private ISession mySession;

        public BaseRepository()
        {
            myConfiguration = new Configuration();
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();
        }

        public void Add(T entity)
        {
            mySession.Save(entity);
            mySession.Transaction.Commit();
        }

        public void Delete(T entity) 
        {
            mySession.Delete(entity);
        }

        public void Update(T entity)
        {
            mySession.Flush();
            mySession.Update(entity);
        }

        public T FindById(int Id)
        {
            return mySession.Get<T>(Id);
        }
    }
}
