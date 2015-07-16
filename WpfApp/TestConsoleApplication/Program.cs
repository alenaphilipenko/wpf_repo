﻿using NHibernate;
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
                Shop.DB.Entities.Users loContact = new Shop.DB.Entities.Users { FirstName = "John", LastName = "Doe", isAdmin = true };
                mySession.Save(loContact);

                mySession.Transaction.Commit();
            }
        }
    }
}