using FoodDelivery.Domain.Common.Customer.ValueObjects;
using FoodDelivery.Domain.Common.Models;

namespace FoodDelivery.Domain.Common.Customer;

public sealed class Customer : AggregateRoot<CustomerId>
{
    public Customer(CustomerId id) : base(id)
    {
    }
}