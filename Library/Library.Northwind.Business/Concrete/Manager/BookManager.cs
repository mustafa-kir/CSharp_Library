using Library.Northwind.Business.Abstract;
using Library.Northwind.Business.ValidationRules.FluentValidation;
using Library.Northwind.DataAccess.Abstract;
using Library.Northwind.Entities.Concrete;
using Libraryy.Core.CrossCuttingConcerns.Validation.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraryy.Core.DataAccess;
using Libraryy.Core.Aspects.Postsharp.TransactionAspects;
using Libraryy.Core.Aspects.Postsharp.ValidationAspects;
using Libraryy.Core.CrossCuttingConcerns.Caching.Microsoft;
using Libraryy.Core.Aspects.Postsharp.CacheAspect;
using Libraryy.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;

namespace Library.Northwind.Business.Concrete.Manager
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;

        public BookManager(IBookDal bookDal, IQueryableRepository<Book> queryable)
        {
            _bookDal = bookDal;
        }
        [FluentValidationAspect(typeof(BookValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Book Add(Book book)
        {
            return _bookDal.Add(book);
        }

        [CacheAspect(typeof(MemoryCacheManager), 120)]
        [LogAspect(typeof(DatabaseLogger))]
        public List<Book> GetAll()
        {
            return _bookDal.GetList();
        }

        public Book GetById(int id)
        {
            return _bookDal.Get(p=>p.BookId == id);
        }

        [TransactionScopeAspect]
        public void TransactionalOperation(Book book1, Book book2)
        {
            //transaction neyse ona modifiye yap
        }

        [FluentValidationAspect(typeof(BookValidator))]
        public Book Update(Book book)
        {
            return _bookDal.Update(book);
        }
    }
}
