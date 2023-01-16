using Shoppy.Catalog.Domain.Products.Enums;
using Shoppy.Domain;

namespace Shoppy.Catalog.Domain.Products.ValueObjects;

public class Dimensions : ValueObject
{
    private Dimensions() { }

    public Dimensions(UnitOfLength unitOfMeasurementForLength, decimal length, decimal width, decimal height, decimal depth)
    {
        UnitOfMeasurementForLength = unitOfMeasurementForLength;
        Length = length;
        Width = width;
        Height = height;
        Depth = depth;
    }

    public UnitOfLength UnitOfMeasurementForLength { get; private set; }
    public decimal Length { get; private set; }
    public decimal Width { get; private set; }
    public decimal Height { get; private set; }
    public decimal Depth { get; private set; }

    protected override IEnumerable<object> GetEquality()
    {
        yield return UnitOfMeasurementForLength;
        yield return Length;
        yield return Width;
        yield return Height;
        yield return Depth;
    }
}