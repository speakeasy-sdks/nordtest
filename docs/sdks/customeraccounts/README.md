# CustomerAccountsSDK
(*CustomerAccounts*)

## Overview

Customer accounts

### Available Operations

* [AccountDetailsUsingGET](#accountdetailsusingget) - Get account details by account id
* [AccountListUsingGET](#accountlistusingget) - Get list of accounts
* [ConvertV4AccountIdToV5UsingGET](#convertv4accountidtov5usingget) - Convert V4 technical account identifier to V5
* [ConvertV5AccountIdToV4UsingGET](#convertv5accountidtov4usingget) - Convert V5 technical account identifier to V4
* [TransactionListUsingGET](#transactionlistusingget) - Get account transactions

## AccountDetailsUsingGET

Get account details by account id

### Example Usage

```csharp
using Accounts;
using Accounts.Models.Shared;
using Accounts.Models.Operations;

var sdk = new AccountsSDK(
    security: new Security() {
        DecoupledAuth = "",
        OAuth2 = "",
    }
);

var res = await sdk.CustomerAccounts.AccountDetailsUsingGETAsync(new AccountDetailsUsingGETRequest() {
    Signature = "illo",
    XIBMClientId = "Diesel",
    XIBMClientSecret = "Savings foreground down",
    XNordeaOriginatingDate = "female Westland",
    XNordeaOriginatingHost = "Program Lamborghini auxiliary",
    Id = "<ID>",
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [AccountDetailsUsingGETRequest](../../models/operations/AccountDetailsUsingGETRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[AccountDetailsUsingGETResponse](../../models/operations/AccountDetailsUsingGETResponse.md)**


## AccountListUsingGET

Get list of accounts

### Example Usage

```csharp
using Accounts;
using Accounts.Models.Shared;
using Accounts.Models.Operations;

var sdk = new AccountsSDK(
    security: new Security() {
        DecoupledAuth = "",
        OAuth2 = "",
    }
);

var res = await sdk.CustomerAccounts.AccountListUsingGETAsync(new AccountListUsingGETRequest() {
    Signature = "tesla",
    XIBMClientId = "recklessly deposit",
    XIBMClientSecret = "et",
    XNordeaOriginatingDate = "payment CSS Electronic",
    XNordeaOriginatingHost = "copy Passenger success",
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [AccountListUsingGETRequest](../../models/operations/AccountListUsingGETRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[AccountListUsingGETResponse](../../models/operations/AccountListUsingGETResponse.md)**


## ConvertV4AccountIdToV5UsingGET

Convert V4 technical account identifier to V5

### Example Usage

```csharp
using Accounts;
using Accounts.Models.Shared;
using Accounts.Models.Operations;

var sdk = new AccountsSDK(
    security: new Security() {
        DecoupledAuth = "",
        OAuth2 = "",
    }
);

var res = await sdk.CustomerAccounts.ConvertV4AccountIdToV5UsingGETAsync(new ConvertV4AccountIdToV5UsingGETRequest() {
    Signature = "West red Bhutan",
    XIBMClientId = "SQL",
    XIBMClientSecret = "HTTP",
    XNordeaOriginatingDate = "Implementation Northeast Creative",
    XNordeaOriginatingHost = "Legacy Nissan",
    Id = "<ID>",
});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [ConvertV4AccountIdToV5UsingGETRequest](../../models/operations/ConvertV4AccountIdToV5UsingGETRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |


### Response

**[ConvertV4AccountIdToV5UsingGETResponse](../../models/operations/ConvertV4AccountIdToV5UsingGETResponse.md)**


## ConvertV5AccountIdToV4UsingGET

Convert V5 technical account identifier to V4

### Example Usage

```csharp
using Accounts;
using Accounts.Models.Shared;
using Accounts.Models.Operations;

var sdk = new AccountsSDK(
    security: new Security() {
        DecoupledAuth = "",
        OAuth2 = "",
    }
);

var res = await sdk.CustomerAccounts.ConvertV5AccountIdToV4UsingGETAsync(new ConvertV5AccountIdToV4UsingGETRequest() {
    Signature = "West",
    XIBMClientId = "calculate gold",
    XIBMClientSecret = "Salad",
    XNordeaOriginatingDate = "quarrelsomely Bacon",
    XNordeaOriginatingHost = "Illinois",
    Id = "<ID>",
});

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [ConvertV5AccountIdToV4UsingGETRequest](../../models/operations/ConvertV5AccountIdToV4UsingGETRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |


### Response

**[ConvertV5AccountIdToV4UsingGETResponse](../../models/operations/ConvertV5AccountIdToV4UsingGETResponse.md)**


## TransactionListUsingGET

Get account transactions

### Example Usage

```csharp
using Accounts;
using Accounts.Models.Shared;
using Accounts.Models.Operations;
using NodaTime;

var sdk = new AccountsSDK(
    security: new Security() {
        DecoupledAuth = "",
        OAuth2 = "",
    }
);

var res = await sdk.CustomerAccounts.TransactionListUsingGETAsync(new TransactionListUsingGETRequest() {
    Signature = "SSL misquote",
    XIBMClientId = "Branding Northwest Pataca",
    XIBMClientSecret = "Hafnium hybrid TLS",
    XNordeaOriginatingDate = "East Manager",
    XNordeaOriginatingHost = "Northwest transmitter living",
    Id = "<ID>",
});

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [TransactionListUsingGETRequest](../../models/operations/TransactionListUsingGETRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[TransactionListUsingGETResponse](../../models/operations/TransactionListUsingGETResponse.md)**

