
# Document

General information that unambiguously identifies a document, such as identification number and issue date time.

## Structure

`Document`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Type1`](../../doc/models/type-1.md) | Optional | - |
| `Number` | `string` | Optional | Unique and unambiguous identification of the referred document.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35`, *Pattern*: ``^[0-9a-zA-Z/\-\?:\(\)\.,'\+ !#$%&\*=^_`\{\\|\}~";<>@\[\\\]]+$`` |
| `RelatedDate` | `string` | Optional | A particular point in the progression of time in a calendar year expressed in the YYYY-MM-DD format. This representation is defined in "XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004" which is aligned with ISO 8601.<br><br>**Constraints**: *Pattern*: `^(?:[1-9]\d{3}-(?:(?:0[1-9]\|1[0-2])-(?:0[1-9]\|1\d\|2[0-8])\|(?:0[13-9]\|1[0-2])-(?:29\|30)\|(?:0[13578]\|1[02])-31)\|(?:[1-9]\d(?:0[48]\|[2468][048]\|[13579][26])\|(?:[2468][048]\|[13579][26])00)-02-29)$` |
| `LineDetails` | [`List<DocumentItem>`](../../doc/models/document-item.md) | Optional | Set of elements used to provide the content of the referred document line. |

## Example (as JSON)

```json
{
  "type": {
    "code": "MSIN",
    "proprietary": "proprietary6"
  },
  "number": "number4",
  "related_date": "related_date4",
  "line_details": [
    {
      "identification": "identification6",
      "description": "description8",
      "amount": {
        "currency_code": "currency_code6",
        "amount": "amount0"
      },
      "credit_debit_indicator": "CRDT",
      "adjustment_reason": "adjustment_reason0"
    }
  ]
}
```

