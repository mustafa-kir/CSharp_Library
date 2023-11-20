using FluentValidation;
using Library.Northwind.Business.ValidationRules.FluentValidation;
using Library.Northwind.Entities.Concrete;

using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Northwind.Business.DeğendecyResolvers.Ninject
{
    public class ValidationModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Book>>().To<BookValidator>().InSingletonScope();
        }
    }
}
