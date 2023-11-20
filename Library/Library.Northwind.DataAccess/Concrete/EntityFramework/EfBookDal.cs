using Library.Northwind.DataAccess.Abstract;
using Library.Northwind.Entities.ComplexTypes;
using Library.Northwind.Entities.Concrete;
using Libraryy.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book, NorthwindContext>, IBookDal
    {
        public List<BookDetail> GetBookDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Books
                             join c in context.Categories on p.CategoryId equals c.CategoryId
                             select new BookDetail
                             {
                                 BookId = p.BookId,
                                 BookName = p.BookName,
                                 CategoryName = c.CategoryName
                             };
                return result.ToList();
            }
        }
    }
}
