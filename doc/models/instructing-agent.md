
# Instructing Agent

## Structure

`InstructingAgent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FinancialInstitutionIdentification` | [`FinancialInstitutionIdentification2`](../../doc/models/financial-institution-identification-2.md) | Required | - |
| `BranchIdentification` | [`BranchIdentification2`](../../doc/models/branch-identification-2.md) | Optional | - |

## Example (as JSON)

```json
{
  "financial_institution_identification": {
    "bicfi": "bicfi4",
    "clearing_system_member_identification": {
      "clearing_system_identification": {
        "key1": "val1",
        "key2": "val2"
      },
      "member_identification": "member_identification8"
    },
    "lei": "lei8",
    "name": "name0",
    "postal_address": {
      "department": "department8",
      "sub_department": "sub_department8",
      "street_name": "street_name4",
      "building_number": "building_number0",
      "building_name": "building_name2",
      "town_name": "town_name0",
      "country": "country6"
    }
  },
  "branch_identification": {
    "identification": "identification4",
    "lei": "lei0",
    "name": "name8",
    "postal_address": {
      "department": "department8",
      "sub_department": "sub_department8",
      "street_name": "street_name4",
      "building_number": "building_number0",
      "building_name": "building_name2",
      "town_name": "town_name0",
      "country": "country6"
    }
  }
}
```

