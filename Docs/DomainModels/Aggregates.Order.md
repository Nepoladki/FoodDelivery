# Domain Aggregates

## Order

```csharp
class Order
{
    Order Create();
    void AddDish(Guid dishId, int quantity, string note);
}
```

```json
{
    "id": { "value" : "00000000-0000-0000-0000-000000000000" },
    "dishIds": [
        "00000000-0000-0000-0000-000000000000",
        "00000000-0000-0000-0000-000000000000"
        ],
    "orderNumber" : 0,
    "note": "Salt-free please",
    "orderStatus" : "Created", //Created, Confirmed, Cooking, Delivery, Cancelled, Completed
    "totalSum": 0.0,
    "createdDateTime": 2000-01-01 00:00:00,
    "payedDateTime": 2000-01-01 00:00:00,
    "completedDateTime": 2000-01-01 00:00:00,
    ""
}

```