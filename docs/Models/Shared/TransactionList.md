# TransactionList

List of transactions


## Fields

| Field                                                   | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `Links`                                                 | List<[Link](../../Models/Shared/Link.md)>               | :heavy_minus_sign:                                      | HATEOAS inspired links: 'rel' and 'href'                |
| `AccountNumber`                                         | [AccountNumber](../../Models/Shared/AccountNumber.md)   | :heavy_minus_sign:                                      | Account number                                          |
| `Transactions`                                          | List<[Transaction](../../Models/Shared/Transaction.md)> | :heavy_minus_sign:                                      | Listed transactions                                     |