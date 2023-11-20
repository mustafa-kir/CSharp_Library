using Library.Northwind.Business.Abstract;
using Library.Northwind.Business.Concrete.Manager;
using Library.Northwind.DataAccess.Abstract;
using Library.Northwind.DataAccess.Concrete.EntityFramework;
using Library.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using Libraryy.Core.DataAccess;
using Libraryy.Core.DataAccess.EntityFramework;
using Libraryy.Core.DataAccess.NHihabernate;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Northwind.Business.DeğendecyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBookService>().To<BookManager>().InSingletonScope();
            Bind<IBookDal>().To<EfBookDal>().InSingletonScope();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<NorthwindContext>();

            Bind<NhihabernateHelper>().To<SqlServerHelper>();

        }
    }
}
