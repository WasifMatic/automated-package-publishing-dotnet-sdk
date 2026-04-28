
# Balance Type Code Enum

Specifies the nature of the balance.
*`CLAV_closing_available`-Closing balance of amount of money that is at the disposal of the account owner on the date specified.
*`CLBD_closing_booked`-Balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
*`FWAV_forward_available`-Forward available balance of money that is at the disposal of the account owner on the date specified.
*`ITAV_interim_available`-Available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
*`OPAV_opening_available`- Opening balance of amount of money that is at the disposal of the account owner on the date specified.
*`OPBD_opening_booked`-Book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.
*`PRCD_previously_closed_booked`-Balance of the account at the previously closed account reporting period. The opening booked balance for the new period has to be equal to this balance.

Usage: the previously booked closing balance should equal (inclusive date) the booked closing balance of the date it references and equal the actual booked opening balance of the current date.

## Enumeration

`BalanceTypeCodeEnum`

## Fields

| Name |
|  --- |
| `CLAV` |
| `CLBD` |
| `FWAV` |
| `ITAV` |
| `OPAV` |
| `OPBD` |
| `PRCD` |

