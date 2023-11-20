using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Northwind.Entities.ComplexTypes
{
    public class BookDetail
    {
        public virtual int BookId { get; set; }
        public virtual string BookName { get; set; }
        public virtual string CategoryName { get; set; }

    }
}
