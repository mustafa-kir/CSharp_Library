using Library.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Northwind.Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        Book GetById(int id);
        Book Add(Book book);
        Book Update(Book book);
        void TransactionalOperation(Book book1, Book book2);

    }
}
