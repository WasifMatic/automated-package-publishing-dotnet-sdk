
# Pet

## Structure

`Pet`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long?` | Optional | - |
| `Name` | `string` | Required | - |
| `Category` | [`Category`](../../doc/models/category.md) | Optional | - |
| `PhotoUrls` | `List<string>` | Required | - |
| `Tags` | [`List<Tag>`](../../doc/models/tag.md) | Optional | - |
| `Status` | [`PetStatusEnum?`](../../doc/models/pet-status-enum.md) | Optional | pet status in the store |

## Example

```csharp
using SwaggerPetstoreOpenAPI310.Standard.Models;
using System.Collections.Generic;

Pet pet = new Pet
{
    Name = "name0",
    PhotoUrls = new List<string>
    {
        "photoUrls5",
        "photoUrls6",
    },
    Id = 72L,
    Category = new Category
    {
        Id = 232L,
        Name = "name2",
    },
    Tags = new List<Tag>
    {
        new Tag
        {
            Id = 26L,
            Name = "name0",
        },
    },
    Status = PetStatusEnum.Available,
};
```

