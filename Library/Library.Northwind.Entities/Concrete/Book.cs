using Libraryy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Northwind.Entities.Concrete
{
    public class Book:IEntity
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int CategoryId { get; set; }
        public string BookAuthor { get; set; }


    }
}
