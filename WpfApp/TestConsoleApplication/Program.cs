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
                Shop.DB.Entities.Emailer loContact = new Shop.DB.Entities.Emailer { Email = "john@mail.com", Owner=1, Type="home"};
                Shop.DB.Entities.Phone loPhone = new Shop.DB.Entities.Phone { PhoneNumber = "567-89-00", Owner = 1, Type="home"};
                Shop.DB.Entities.Product loProduct = new Shop.DB.Entities.Product { Manufacturer = "P&G", Name = "Shampoo", Price = 12 };

                mySession.Save(loContact);
                mySession.Save(loPhone);
                mySession.Save(loProduct);

                mySession.Transaction.Commit();
            }
        }
    }
}
