using Shoppy.Catalog.Domain.Domain.Products;
using Shoppy.Domain;

namespace Shoppy.Catalog.Domain.Products.Events;

public class ProductDeleted : DomainEvent
{
    internal ProductDeleted(Product product)
    {

    }
}