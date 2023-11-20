using Library.Northwind.Business.Concrete.Manager;
using Library.Northwind.DataAccess.Abstract;
using Library.Northwind.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using FluentValidation;
using System;

namespace Library.Northwind.Business.Tests
{
    [TestClass]
    public class BookManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Book_Validation_Check()
        {
            Mock<IBookDal> mock = new Mock<IBookDal>();
            BookManager bookManager = new BookManager(mock.Object);

            bookManager.Add(new Book());
        }
    }
}
