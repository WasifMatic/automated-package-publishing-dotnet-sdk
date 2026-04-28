
# Related Parties

## Structure

`RelatedParties`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `InitiatingParty` | `object` | Optional | - |
| `Debtor` | `object` | Optional | - |
| `DebtorAccount` | [`DebtorAccount`](../../doc/models/debtor-account.md) | Optional | - |
| `UltimateDebtor` | `object` | Optional | - |
| `Creditor` | `object` | Optional | - |
| `CreditorAccount` | [`CreditorAccount`](../../doc/models/creditor-account.md) | Optional | - |
| `UltimateCreditor` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "initiating_party": {
    "key1": "val1",
    "key2": "val2"
  },
  "debtor": {
    "key1": "val1",
    "key2": "val2"
  },
  "debtor_account": {
    "identification": {
      "key1": "val1",
      "key2": "val2"
    },
    "type": {
      "key1": "val1",
      "key2": "val2"
    },
    "currency": "currency4",
    "name": "name4",
    "alternate_identification": {
      "identification": "identification2",
      "scheme_name": "scheme_name6",
      "issuer": "issuer0"
    }
  },
  "ultimate_debtor": {
    "key1": "val1",
    "key2": "val2"
  },
  "creditor": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

