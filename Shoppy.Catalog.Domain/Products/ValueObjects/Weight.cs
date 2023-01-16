using Shoppy.Catalog.Domain.Products.Enums;
using Shoppy.Domain;

namespace Shoppy.Catalog.Domain.Products.ValueObjects;

public class Weight : ValueObject
{
    public Weight(UnitOfMass unitOfMeasurementForMass, decimal value)
    {
        UnitOfMeasurementForMass = unitOfMeasurementForMass;
        Value = value;
    }
    public UnitOfMass UnitOfMeasurementForMass { get; private set; }
    public decimal Value { get; private set; }

    protected override IEnumerable<object> GetEquality()
    {
        yield return UnitOfMeasurementForMass;
        yield return Value;
    }
}