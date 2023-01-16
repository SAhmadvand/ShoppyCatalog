namespace Shoppy.Catalog.Domain.Products.Services;

public interface IProductVendorValidator
{
    Task ValidateAsync(long vendorId, CancellationToken cancellationToken = default);
}