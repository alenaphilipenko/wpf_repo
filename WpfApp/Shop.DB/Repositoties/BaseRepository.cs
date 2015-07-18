using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DB.Interfaces;
using NHibernate.Cfg;
using NHibernate;

namespace Shop.DB.Repositoties
{
    public class BaseRepository<T> where T : IEntity
    {
        Configuration myConfiguration;
        ISessionFactory mySessionFactory;
        ISession mySession;

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
