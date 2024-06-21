# Domain Aggregates

## Menu

```csharp
class Menu
{
    Menu Create();
}
```

```json
{
    "id": { "value": "00000000-0000-0000-0000-000000000000" },
    "name": "Yummy Menu",
    "description": "A menu with yummy food",
    "sections": [
        {
            "id": { "value": "00000000-0000-0000-0000-000000000000" },
            "name": "Appetizers",
            "description": "Starters",
            "items": [
                {
                    "id": { "value": "00000000-0000-0000-0000-000000000000" },
                    "name": "Fried Pickles",
                    "description": "Deep fried pickles",
                    "price": 100
                }
            ]
        }
    ],
    "restarauntId": { "value": "00000000-0000-0000-0000-000000000000" },
    "createdDateTime": "2020-01-01T00:00:00.0000000Z",
    "updatedDateTime": "2020-01-01T00:00:00.0000000Z"
}

```