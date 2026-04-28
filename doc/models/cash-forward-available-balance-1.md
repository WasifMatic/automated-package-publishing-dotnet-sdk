
# Cash Forward Available Balance 1

Individual forward available balance details on a given cash account. It is the forward available balance of money that is at the disposal of the account owner on the date specified.

## Structure

`CashForwardAvailableBalance1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BalanceAmount` | [`BalanceAmount`](../../doc/models/balance-amount.md) | Required | - |
| `AvailabilityDate` | `string` | Required | A particular point in the progression of time in a calendar year expressed in the YYYY-MM-DD format. This representation is defined in "XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004" which is aligned with ISO 8601.<br><br>**Constraints**: *Pattern*: `^(?:[1-9]\d{3}-(?:(?:0[1-9]\|1[0-2])-(?:0[1-9]\|1\d\|2[0-8])\|(?:0[13-9]\|1[0-2])-(?:29\|30)\|(?:0[13578]\|1[02])-31)\|(?:[1-9]\d(?:0[48]\|[2468][048]\|[13579][26])\|(?:[2468][048]\|[13579][26])00)-02-29)$` |

## Example (as JSON)

```json
{
  "balance_amount": {
    "amount": {
      "currency": "currency2",
      "amount": "amount0"
    },
    "credit_debit_indicator": "CRDT"
  },
  "availability_date": "availability_date8"
}
```

