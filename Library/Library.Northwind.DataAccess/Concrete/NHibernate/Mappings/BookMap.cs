using FluentNHibernate.Mapping;
using Library.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Northwind.DataAccess.Concrete.NHibernate.Mappings
{
    public class BookMap:ClassMap<Book>
    {
        public BookMap()
        {
            Table(@"Books");
            LazyLoad();
            Id(x => x.BookId).Column("BookID");
            Map(x => x.CategoryId).Column("CategoryID");
            Map(x => x.BookName).Column("BookName");
            Map(x => x.BookAuthor).Column("BookAuthor");


        }
    }
}
