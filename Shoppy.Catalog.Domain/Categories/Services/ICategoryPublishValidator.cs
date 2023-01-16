namespace Shoppy.Catalog.Domain.Categories.Services;

public interface ICategoryPublishValidator
{
    Task ValidateAsync(long categoryId, CancellationToken cancellationToken = default);
}