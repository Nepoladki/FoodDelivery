using FoodDelivery.Domain.Common.Models;

namespace FoodDelivery.Domain.Common.Order.ValueObjects;

public sealed class OrderId : ValueObject
{
    public Guid Value { get; }
    private OrderId(Guid value)
    {
        Value = value;
    }

    public static OrderId CreateUnique()
    {
        return new(Guid.NewGuid());
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}