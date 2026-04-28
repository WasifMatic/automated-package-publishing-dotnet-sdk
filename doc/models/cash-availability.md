
# Cash Availability

Indicates when the amount of money will become available, that is can be accessed and start generating interest.

## Structure

`CashAvailability`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Date` | `string` | Required | A particular point in the progression of time in a calendar year expressed in the YYYY-MM-DD format. This representation is defined in "XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004" which is aligned with ISO 8601.<br><br>**Constraints**: *Pattern*: `^(?:[1-9]\d{3}-(?:(?:0[1-9]\|1[0-2])-(?:0[1-9]\|1\d\|2[0-8])\|(?:0[13-9]\|1[0-2])-(?:29\|30)\|(?:0[13578]\|1[02])-31)\|(?:[1-9]\d(?:0[48]\|[2468][048]\|[13579][26])\|(?:[2468][048]\|[13579][26])00)-02-29)$` |
| `Amount` | [`Amount1`](../../doc/models/amount-1.md) | Required | - |
| `CreditDebitIndicator` | [`CreditDebitCodeEnum`](../../doc/models/credit-debit-code-enum.md) | Required | - |

## Example (as JSON)

```json
{
  "date": "date4",
  "amount": {
    "currency_code": "currency_code6",
    "amount": "amount0"
  },
  "credit_debit_indicator": "CRDT"
}
```

