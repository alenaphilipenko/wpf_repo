﻿using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DB
{
    public class Class1
    {
        private Configuration myConfiguration;
        private ISessionFactory mySessionFactory;
        private ISession mySession;

        public Class1()
        {
            myConfiguration = new Configuration();
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();

            // Add Record
            using (mySession.BeginTransaction())
            {
                Entities.Users loContact = new Entities.Users { FirstName = "John", LastName = "Doe", isAdmin = true};
                mySession.Save(loContact);

                mySession.Transaction.Commit();
            }
        }
    }
}
