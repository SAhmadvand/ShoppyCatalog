namespace Shoppy.Catalog.Domain.Products.Services;

public interface IProductDeleteValidator
{
    Task ValidateAsync(long productId, CancellationToken cancellationToken = default);
}