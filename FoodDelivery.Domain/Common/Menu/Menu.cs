using FoodDelivery.Domain.Common.Menu.Entities;
using FoodDelivery.Domain.Common.Menu.ValueObjects;
using FoodDelivery.Domain.Common.Models;

namespace FoodDelivery.Domain.Common.Menu;

public sealed class Menu : AggregateRoot<MenuId>
{
    private readonly List<MenuSection> _sections = new();
    public string Name { get; }
    public string Description { get; }
    public DateTime createdDateTime { get; }
    public DateTime updatedDateTime { get; }
    public IReadOnlyList<MenuSection> Sections => _sections.AsReadOnly();
}