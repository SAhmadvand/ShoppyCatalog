using Shoppy.Catalog.Domain.Domain.Products;
using System.Linq.Expressions;

namespace Shoppy.Catalog.Domain.Products;

public interface IProductRepository
{
    Task<bool> IsExists(Expression<Func<Product, bool>> predicate, CancellationToken cancellationToken = default);
    Task InsertAsync(Product entity, CancellationToken cancellationToken = default);
    Task<Product> GetAsync(long id, CancellationToken cancellationToken = default);
    void Update(Product entity);
    void Delete(Product entity);
}