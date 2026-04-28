
# Transaction Agents

Provides further details on the agents specific to the individual transaction.

## Structure

`TransactionAgents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `InstructingAgent` | [`InstructingAgent`](../../doc/models/instructing-agent.md) | Optional | - |
| `InstructedAgent` | [`InstructedAgent`](../../doc/models/instructed-agent.md) | Optional | - |
| `DebtorAgent` | [`DebtorAgent`](../../doc/models/debtor-agent.md) | Optional | - |
| `CreditorAgent` | [`CreditorAgent`](../../doc/models/creditor-agent.md) | Optional | - |
| `IntermediaryAgent1` | [`IntermediaryAgent1`](../../doc/models/intermediary-agent-1.md) | Optional | - |
| `IntermediaryAgent2` | [`IntermediaryAgent1`](../../doc/models/intermediary-agent-1.md) | Optional | - |
| `IntermediaryAgent3` | [`IntermediaryAgent1`](../../doc/models/intermediary-agent-1.md) | Optional | - |

## Example (as JSON)

```json
{
  "instructing_agent": {
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
  },
  "instructed_agent": {
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
  },
  "debtor_agent": {
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
  },
  "creditor_agent": {
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
  },
  "intermediary_agent1": {
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
}
```

