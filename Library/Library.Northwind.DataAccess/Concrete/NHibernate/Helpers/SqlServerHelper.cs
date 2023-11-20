using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Libraryy.Core.DataAccess.NHihabernate;
using NHibernate;

namespace Library.Northwind.DataAccess.Concrete.NHibernate.Helpers
{
    public class SqlServerHelper : NhihabernateHelper
    {
        protected override ISessionFactory InitializeFactoy()
        {
            return Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(c => c.FromConnectionStringWithKey("NorthwindContext"))).Mappings(t => t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())).BuildSessionFactory();
        }
    }
}
