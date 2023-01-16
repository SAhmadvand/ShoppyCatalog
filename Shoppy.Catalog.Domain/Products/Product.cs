using Shoppy.Catalog.Domain.Products.Entites;
using Shoppy.Catalog.Domain.Products.Enums;
using Shoppy.Catalog.Domain.Products.Events;
using Shoppy.Catalog.Domain.Products.Services;
using Shoppy.Catalog.Domain.Products.ValueObjects;
using Shoppy.Domain;

namespace Shoppy.Catalog.Domain.Domain.Products;

public partial class Product : AggregateRoot<long>
{
    #region Constructors
    private Product(long id, string code, string name, long categoryId,
        long brandId, long vendorId, Weight weight, Dimensions dimensions) : base(id)
    {
        Code = code;
        Name = name;
        CategoryId = categoryId;
        BrandId = brandId;
        VendorId = vendorId;
        Weight = weight;
        Dimensions = dimensions;

        State = ProductState.Draft;
        
        RaiseEvent(new ProductCreated(this));
    }

    #endregion
    
    #region Fields
    private readonly List<ProductAttribute> _attributes = new();
    #endregion

    #region Properties
    public string Code { get; private set; } = null!;

    public string Name { get; private set; } = null!;

    public long CategoryId { get; private set; }

    public long BrandId { get; private set; }

    public long VendorId { get; private set; }

    public ProductState State { get; private set; }

    public Weight Weight { get; private set; }

    public Dimensions Dimensions { get; private set; }

    public IReadOnlyCollection<ProductAttribute> Attributes => _attributes;
    #endregion

    #region Methods

    public async Task DeleteAsync(IProductDeleteValidator validator, CancellationToken cancellationToken = default)
    {
        await validator.ValidateAsync(Id, cancellationToken);
        /// todo: add delete logic
        RaiseEvent(new ProductDeleted(this));
    }
    public async Task PublishAsync(IProductPublishValidator validator, CancellationToken cancellationToken = default)
    {
        await validator.ValidateAsync(Id, cancellationToken);
        /// todo: add publish category logic
        State = ProductState.Publish;
        RaiseEvent(new ProductStateChanged(this));
    }
    public async Task UnPublishAsync(IProductUnPublishValidator validator, CancellationToken cancellationToken = default)
    {
        await validator.ValidateAsync(Id, cancellationToken);
        /// todo: add unPublish category logic
        State = ProductState.UnPublish;
        RaiseEvent(new ProductStateChanged(this));
    }
    #endregion
}