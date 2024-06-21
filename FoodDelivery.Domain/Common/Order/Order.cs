using FoodDelivery.Domain.Common.Models;
using FoodDelivery.Domain.Common.Order.ValueObjects;

namespace FoodDelivery.Domain.Common.Order;

public sealed class Order : AggregateRoot<OrderId>
{
    private readonly List<DishId> = null;
    public int OrderNumber { get; }
    public string Note { get; }
    public int OrderStatus { get; }
    public decimal TotalSum { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime PayedDateTime { get; }
    public DateTime CompletedDateTime { get; }
}