using FoodDelivery.Domain.Common.Models;

namespace FoodDelivery.Domain.Common.Customer.ValueObjects;

public sealed class CustomerId : ValueObject
{
    public Guid Value { get; }
    private CustomerId(Guid value)
    {
        Value = value;
    }
    public static CustomerId CreateUnique()
    {
        return new(Guid.NewGuid());
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}