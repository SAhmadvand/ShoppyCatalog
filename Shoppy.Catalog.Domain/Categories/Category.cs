using Shoppy.Domain;
using Shoppy.Catalog.Domain.Categories.Services;
using Shoppy.Catalog.Domain.Categories.Enums;
using Shoppy.Catalog.Domain.Categories.Events;

namespace Shoppy.Catalog.Domain.Domain.Categories;

public partial class Category : AggregateRoot<long>
{
    #region Constructors
    private Category(long id, long? parentIdId, string code, string name, bool isAssignableToProduct) : base(id)
    {
        ParentId = parentIdId;
        Code = code;
        Name = name;
        IsAssignableToProduct = isAssignableToProduct;

        VisibilityVisibilityState = CategoryVisibilityState.Draft;

        RaiseEvent(new CategoryCreated(this));
    }
    #endregion

    #region Properties
    public long? ParentId { get; private set; }
    public string Code { get; private set; }
    public string Name { get; private set; }
    public bool IsAssignableToProduct { get; private set; }
    public CategoryVisibilityState VisibilityVisibilityState { get; private set; }
    #endregion

    #region Methods
    public async Task DeleteAsync(ICategoryDeleteValidator validator, CancellationToken cancellationToken = default)
    {
        await validator.ValidateAsync(Id, cancellationToken);
        /// TODO: add delete logic
        RaiseEvent(new CategoryDeleted(this));
    }
    public async Task PublishAsync(ICategoryPublishValidator validator, CancellationToken cancellationToken = default)
    {
        await validator.ValidateAsync(Id, cancellationToken);
        /// TODO: add publish category logic
        VisibilityVisibilityState = CategoryVisibilityState.Publish;
        RaiseEvent(new CategoryStateChanged(this));
    }
    public async Task UnPublishAsync(ICategoryUnPublishValidator validator, CancellationToken cancellationToken = default)
    {
        await validator.ValidateAsync(Id, cancellationToken);
        /// TODO: add unPublish category logic
        VisibilityVisibilityState = CategoryVisibilityState.UnPublish;
        RaiseEvent(new CategoryStateChanged(this));
    }
    #endregion
}