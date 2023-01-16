namespace Shoppy.Catalog.Domain.Products.Services;

public interface IProductUnPublishValidator
{
    Task ValidateAsync(long productId, CancellationToken cancellationToken = default);
}