namespace Shoppy.Catalog.Domain.Domain.Categories;

public partial class Category
{
    public static Task<Category> CreateAsync()
    {
        return Task.FromResult((Category)default);
    }
}