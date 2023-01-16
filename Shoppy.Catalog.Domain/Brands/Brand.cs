using Shoppy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.Catalog.Domain.Brands
{
    public class Brand : AggregateRoot<long>
    {
        #region Constructors
        private Brand()
        {
        }

        public Brand(long id)
        {
            Id = id;
        }
        #endregion
    }
}
