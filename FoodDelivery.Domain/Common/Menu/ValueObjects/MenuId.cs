using FoodDelivery.Domain.Common.Models;

namespace FoodDelivery.Domain.Common.Menu.ValueObjects;

public sealed class MenuId : ValueObject
{
    public Guid Value { get; }
    private MenuId(Guid value)
    {
        Value = value;
    }
    public static MenuId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}