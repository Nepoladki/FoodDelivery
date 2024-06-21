# Domain Aggregates

## Restaraunt

```csharp
class Restaraunt
{
    Restaraunt Create();
}
```

```json
{
  "id": {
    "value": "00000000-0000-0000-0000-000000000000"
  },
  "name": "Yummy Restaurant",
  "address": {
    "street": "456 Oak St",
    "city": "Anytown",
    "state": "CA",
    "zipCode": "12345"
  },
  "openingHours": {
    "monday": {
      "open": "11:00",
      "close": "22:00"
    },
    "tuesday": {
      "open": "11:00",
      "close": "22:00"
    },
    "wednesday": {
      "open": "11:00",
      "close": "22:00"
    },
    "thursday": {
      "open": "11:00",
      "close": "22:00"
    },
    "friday": {
      "open": "11:00",
      "close": "23:00"
    },
    "saturday": {
      "open": "12:00",
      "close": "23:00"
    },
    "sunday": {
      "open": "12:00",
      "close": "21:00"
    }
  },
  "menu": {
    "id": { "value": "00000000-0000-0000-0000-000000000000" },
    "name": "Yummy Menu",
    "description": "A menu with yummy food",
    "dishes": [
      {
        "id": { "value": "00000000-0000-0000-0000-000000000000" },
        "name": "Fried Pickles",
        "description": "Deep fried pickles",
        "price": 5.99
      }
    ]
  },
  "createdAt": "2024-06-21T11:43:00Z",
  "updatedAt": "2024-06-21T11:43:00Z"
}


```