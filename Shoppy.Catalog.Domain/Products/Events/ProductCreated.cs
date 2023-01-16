using Shoppy.Catalog.Domain.Domain.Products;
using Shoppy.Domain;

namespace Shoppy.Catalog.Domain.Products.Events;

public class ProductCreated : DomainEvent
{
    internal ProductCreated(Product product)
    {

    }
}