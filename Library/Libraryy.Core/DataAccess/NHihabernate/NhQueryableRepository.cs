using Libraryy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraryy.Core.DataAccess.NHihabernate
{
    public class NhQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private NhihabernateHelper _nhihabernateHelper;
        IQueryable<T> _entities;

        public NhQueryableRepository(NhihabernateHelper nhihabernateHelper)
        {
            _nhihabernateHelper = nhihabernateHelper;
        }

        public IQueryable<T> Table { get {return this.Entities; } }

        public virtual IQueryable<T> Entities { 
            get { return _entities ?? (_entities = _nhihabernateHelper.OpenSession().Query<T>()); } 
        }
    }
}
