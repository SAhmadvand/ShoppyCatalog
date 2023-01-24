using Shoppy.Domain;

namespace Shoppy.Catalog.Domain.Brands;

public class ValidCategory : Entity<long>
{
    #region Constructors

    public ValidCategory()
    {
            
    }
    
    private ValidCategory(long id, long categoryId)
    {
        Id = id;
        CategoryId = categoryId;
    }
    
    #endregion
    
    public long CategoryId { get; private set; }
}