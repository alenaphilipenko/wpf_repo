using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration myConfiguration;
            ISessionFactory mySessionFactory;
            ISession mySession;

            myConfiguration = new Configuration();
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();

            // Add Record
            using (mySession.BeginTransaction())
            {
                Shop.DB.Entities.User loContact = new Shop.DB.Entities.User { FirstName = "John", LastName = "Doe", IsAdmin = true };
                mySession.Save(loContact);

                mySession.Transaction.Commit();
            }
        }
    }
}
