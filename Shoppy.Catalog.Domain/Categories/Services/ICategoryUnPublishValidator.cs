namespace Shoppy.Catalog.Domain.Categories.Services;

public interface ICategoryUnPublishValidator
{
    Task ValidateAsync(long categoryId, CancellationToken cancellationToken = default);
}