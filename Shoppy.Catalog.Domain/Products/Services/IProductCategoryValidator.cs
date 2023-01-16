namespace Shoppy.Catalog.Domain.Products.Services;

public interface IProductCategoryValidator
{
    Task ValidateAsync(long categoryId, CancellationToken cancellationToken = default);
}