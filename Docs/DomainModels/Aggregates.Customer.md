# Domain Aggregates

## Customer

```csharp
class Customer
{
    Customer Create();
}
```

```json
{
    "id": { "value": "00000000-0000-0000-0000-000000000000" },
    "firstName": "RealName",
    "lastName": "RealLastName",
    "email": "user@email.ru",
    "phoneNumber": "8-999-888-77-66",
    "hashedPassword": "suckmyasshashedpassword",
    "isActive": true,
    "note": "justSomeNote",
    "createdDateTime": 2000-01-01 00:00:00,
    "updatedDateTime": 2000-01-01 00:00:00,
    "deliveryAddresses": [
        {
        "id": { "value": "00000000-0000-0000-0000-000000000000" },
        "street": "Пушкина",
        "city": "Москва",
        "house": "1",
        "flat": "45"
        }
    ]
}
```