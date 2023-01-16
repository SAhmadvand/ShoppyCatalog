namespace Shoppy.Catalog.Domain.Categories.Services;

public interface ICategoryDeleteValidator
{
    Task ValidateAsync(long categoryId, CancellationToken cancellationToken = default);
}