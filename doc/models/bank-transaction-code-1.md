
# Bank Transaction Code 1

## Structure

`BankTransactionCode1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DomainCode` | `string` | Optional | Specifies the external domain code of the bank transaction code (business area of the underlying transaction) in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `4` |
| `FamilyCode` | `string` | Optional | Specifies the bank transaction code family within a domain, as published in an external bank transaction code family code list. External code sets can be downloaded from www.iso20022.org.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `4` |
| `SubFamilyCode` | `string` | Optional | Specifies the bank transaction code sub-product (sub-family) family within a specific family, as published in an external bank transaction code sub-family code list. External code sets can be downloaded from www.iso20022.org.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `4` |
| `ProprietaryCode` | `string` | Optional | Proprietary bank transaction code to identify the underlying transaction.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |
| `Issuer` | `string` | Optional | Identification of the issuer of the proprietary bank transaction code.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `35` |

## Example (as JSON)

```json
{
  "domain_code": "domain_code8",
  "family_code": "family_code8",
  "sub_family_code": "sub_family_code2",
  "proprietary_code": "proprietary_code0",
  "issuer": "issuer2"
}
```

