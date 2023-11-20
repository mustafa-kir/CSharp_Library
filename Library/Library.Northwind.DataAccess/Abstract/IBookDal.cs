using Library.Northwind.Entities.ComplexTypes;
using Library.Northwind.Entities.Concrete;
using Libraryy.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Northwind.DataAccess.Abstract
{
    public interface IBookDal: IEntityRepository<Book>
    {
        List<BookDetail> GetBookDetails();
    }
}
