using Shoppy.Domain;

namespace Shoppy.Catalog.Domain.Attributes
{
    public class Attribute : AggregateRoot<long>
    {
        #region Constructors
        private Attribute()
        {
        }

        public Attribute(long id)
        {
            Id = id;
        }
        #endregion
    }
}
