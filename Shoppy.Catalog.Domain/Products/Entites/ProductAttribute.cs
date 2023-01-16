using Shoppy.Domain;

namespace Shoppy.Catalog.Domain.Products.Entites;

public class ProductAttribute : Entity<long>
{
    private ProductAttribute()
    {
    }

    public ProductAttribute(long attributeId, string value, bool isSpecific)
    {
        AttributeId = attributeId;
        Value = value;
        IsSpecific = isSpecific;
    }
    public long AttributeId { get; private set; }
    public string Value { get; private set; } = null!;
    public bool IsSpecific { get; private set; }
}