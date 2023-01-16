using Shoppy.Catalog.Domain.Products.Services;
using Shoppy.Catalog.Domain.Products.ValueObjects;

namespace Shoppy.Catalog.Domain.Domain.Products;

public partial class Product
{
    private Product(){ }
    
    public async static Task<Product> CreateAsync(
        long id, string code, string name, long categoryId, long brandId,
        long vendorId, Weight weight, Dimensions dimensions,
        IProductCodeValidator codeValidator,
        IProductVendorValidator vendorValidator,
        IProductCategoryValidator categoryValidator,
        IProductBrandValidator brandValidator,
        CancellationToken cancellationToken = default)
    {
        return new Product(id, code, name, categoryId, brandId, vendorId, weight, dimensions);
    }
}