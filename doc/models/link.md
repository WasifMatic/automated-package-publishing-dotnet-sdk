
# Link

Contains a generic structure to support hyperlinking (REST level 3).

## Structure

`Link`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Href` | `string` | Required | Specifies the link as a url. The href member identifies the target IRI location of the resource.<br><br>**Constraints**: *Maximum Length*: `256` |
| `Rel` | `string` | Optional | Specifies the operation. The value of this property MUST be a string. This property is required except self. The self reference contains the URI of the same resource.<br><br>**Constraints**: *Maximum Length*: `35` |
| `Type` | `string` | Optional | The value containing the HTTP verb used for the URL. If the type element is not included then the link MUST be available using GET.<br><br>**Constraints**: *Maximum Length*: `35` |

## Example (as JSON)

```json
{
  "href": "href0",
  "rel": "rel4",
  "type": "type2"
}
```

