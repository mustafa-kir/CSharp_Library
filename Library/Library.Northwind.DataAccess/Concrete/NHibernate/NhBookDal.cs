using Library.Northwind.DataAccess.Abstract;
using Library.Northwind.Entities.ComplexTypes;
using Library.Northwind.Entities.Concrete;
using Libraryy.Core.DataAccess.NHihabernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhBookDal:NHEntityRepositoryBase<Book>,IBookDal
    {
        private NhihabernateHelper _nhihabernateHelper;
        public NhBookDal(NhihabernateHelper nhihabernateHelper): base(nhihabernateHelper)
        {
            _nhihabernateHelper = nhihabernateHelper;
        }

        public List<BookDetail> GetBookDetails()
        {
            using (var session = _nhihabernateHelper.OpenSession())
            {
                var result = from p in session.Query<Book>()
                             join c in session.Query<Category>() on p.CategoryId equals c.CategoryId
                             select new BookDetail
                             {
                                 BookId = p.BookId,
                                 CategoryName = c.CategoryName,
                                 BookName = p.BookName

                             };
                return result.ToList();

            }
        }
    }
}
