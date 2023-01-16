namespace Shoppy.Catalog.Domain.Products.Services;

public interface IProductBrandValidator
{
    Task ValidateAsync(long brandId, CancellationToken cancellationToken = default);
}