using Library.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Northwind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class BookMap:EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            ToTable(@"Books", @"dbo");
            HasKey(x => x.BookId);

            Property(x => x.BookId).HasColumnName("BookID");
            Property(x => x.CategoryId).HasColumnName("CategoryId");
            Property(x => x.BookName).HasColumnName("BookName");
            Property(x => x.BookAuthor).HasColumnName("BookAuthor");

        }
    }
}
