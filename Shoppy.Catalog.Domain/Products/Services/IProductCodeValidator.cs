namespace Shoppy.Catalog.Domain.Products.Services;

public interface IProductCodeValidator
{
    Task ValidateAsync(long productId, string code, CancellationToken cancellationToken = default);
}