using FluentValidation;
using Library.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Northwind.Business.ValidationRules.FluentValidation
{
    class BookValidator:AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Category Id Not Empty");
            RuleFor(p => p.BookName).Length(2, 20);// kitap adı 2 ile 20 arasında olmalı.
            RuleFor(p => p.BookAuthor).NotEmpty();

        }
    }
}
