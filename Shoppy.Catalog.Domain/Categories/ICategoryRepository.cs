using Shoppy.Catalog.Domain.Domain.Categories;
using System.Linq.Expressions;

namespace Shoppy.Catalog.Domain.Categories;

public interface ICategoryRepository
{
    Task<bool> IsExists(Expression<Func<Category, bool>> predicate, CancellationToken cancellationToken = default);
    Task InsertAsync(Category entity, CancellationToken cancellationToken = default);
    Task<Category> GetAsync(long id, CancellationToken cancellationToken = default);
    void Update(Category entity);
    void Delete(Category entity);
}