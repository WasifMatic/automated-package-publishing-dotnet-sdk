
# Charge Bearer Type Code Enum

Specifies which party(ies) will pay charges due for processing of the instruction.
*`DEBT_borne_by_debtor`-All transaction charges are to be borne by the debtor.
*`CRED_borne_by_creditor`-All transaction charges are to be borne by the creditor.
*`SHAR_shared`-In a credit transfer context, means that transaction charges on the sender side are to be borne by the debtor, transaction charges on the receiver side are to be borne by the creditor. In a direct debit context, means that transaction charges on the sender side are to be borne by the creditor, transaction charges on the receiver side are to be borne by the debtor.
*`SLEV_following_service_level`-Charges are to be applied following the rules agreed in the service level and/or scheme.

## Enumeration

`ChargeBearerTypeCodeEnum`

## Fields

| Name |
|  --- |
| `DEBT` |
| `CRED` |
| `SHAR` |
| `SLEV` |

