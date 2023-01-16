namespace Shoppy.Catalog.Domain.Products.Services;

public interface IProductPublishValidator
{
    Task ValidateAsync(long productId, CancellationToken cancellationToken = default);
}