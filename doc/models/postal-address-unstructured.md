
# Postal Address Unstructured

Information that locates and identifies a specific address.

## Structure

`PostalAddressUnstructured`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AddressLine` | `string` | Required | Information that locates and identifies a specific address, as defined by postal services, presented in free format text.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `105` |
| `Country` | `string` | Optional | Specify the country code.<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2`, *Pattern*: `^[A-Z]{2,2}$` |

## Example (as JSON)

```json
{
  "address_line": "address_line6",
  "country": "country4"
}
```

