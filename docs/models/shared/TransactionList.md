# TransactionList

List of transactions


## Fields

| Field                                                   | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `Links`                                                 | List<[Link](../../models/shared/Link.md)>               | :heavy_minus_sign:                                      | HATEOAS inspired links: 'rel' and 'href'                |
| `AccountNumber`                                         | [AccountNumber](../../models/shared/AccountNumber.md)   | :heavy_minus_sign:                                      | Account number                                          |
| `Transactions`                                          | List<[Transaction](../../models/shared/Transaction.md)> | :heavy_minus_sign:                                      | Listed transactions                                     |