using NHibernate;
using NHibernate.Cfg;
using Shop.DB.Entities;

namespace TestConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration myConfiguration;
            ISessionFactory mySessionFactory;
            ISession mySession;
            //
            myConfiguration = new Configuration();
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();

            // Add Record
            using (mySession.BeginTransaction())
            {
                Emailer loContact = new Emailer { Email = "john@mail.com", Owner=1, Type="home"};
                Phone loPhone = new Phone { PhoneNumber = "567-89-00", Owner = 1, Type="home"};
                Product loProduct = new Product { Manufacturer = "P&G", Name = "Shampoo", Price = 12 };

                mySession.Save(loContact);
                mySession.Save(loPhone);
                mySession.Save(loProduct);

                mySession.Transaction.Commit();
            }
        }
    }
}
