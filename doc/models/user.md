
# User

## Structure

`User`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long?` | Optional | - |
| `Username` | `string` | Optional | - |
| `FirstName` | `string` | Optional | - |
| `LastName` | `string` | Optional | - |
| `Email` | `string` | Optional | - |
| `Password` | `string` | Optional | - |
| `Phone` | `string` | Optional | - |
| `UserStatus` | `int?` | Optional | User Status |

## Example

```csharp
using SwaggerPetstoreOpenAPI310.Standard.Models;

User user = new User
{
    Id = 76L,
    Username = "username0",
    FirstName = "firstName4",
    LastName = "lastName4",
    Email = "email6",
};
```

