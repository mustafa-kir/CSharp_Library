﻿using FluentNHibernate.Mapping;
using Library.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Northwind.DataAccess.Concrete.NHibernate.Mappings
{
    public class CategoryMap:ClassMap<Category>
    {
        public CategoryMap()
        {
            Table(@"Categories");
            LazyLoad();
            Map(x => x.CategoryId).Column("CategoryID");
            Map(x => x.CategoryName).Column("CategoryName");


        }
    }
}
