using Library.Northwind.DataAccess.Abstract;
using Library.Northwind.Entities.Concrete;
using Libraryy.Core.DataAccess.NHihabernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhCategoryDal: NHEntityRepositoryBase<Category>,ICategoryDal
    {
        public NhCategoryDal(NhihabernateHelper nhihabernateHelper) : base(nhihabernateHelper)
        {

        }
    }
}
