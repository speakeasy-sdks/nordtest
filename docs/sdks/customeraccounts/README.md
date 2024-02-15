# CustomerAccounts
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

var sdk = new AccountsSDK(security: new Security() {
        DecoupledAuth = "Bearer <YOUR_ACCESS_TOKEN_HERE>",
    });

AccountDetailsUsingGETRequest req = new AccountDetailsUsingGETRequest() {
    Signature = "<value>",
    XIBMClientId = "<value>",
    XIBMClientSecret = "<value>",
    XNordeaOriginatingDate = "<value>",
    XNordeaOriginatingHost = "<value>",
    Id = "<id>",
};

var res = await sdk.CustomerAccounts.AccountDetailsUsingGETAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [AccountDetailsUsingGETRequest](../../Models/Operations/AccountDetailsUsingGETRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[AccountDetailsUsingGETResponse](../../Models/Operations/AccountDetailsUsingGETResponse.md)**


## AccountListUsingGET

Get list of accounts

### Example Usage

```csharp
using Accounts;
using Accounts.Models.Shared;
using Accounts.Models.Operations;

var sdk = new AccountsSDK(security: new Security() {
        DecoupledAuth = "Bearer <YOUR_ACCESS_TOKEN_HERE>",
    });

AccountListUsingGETRequest req = new AccountListUsingGETRequest() {
    Signature = "<value>",
    XIBMClientId = "<value>",
    XIBMClientSecret = "<value>",
    XNordeaOriginatingDate = "<value>",
    XNordeaOriginatingHost = "<value>",
};

var res = await sdk.CustomerAccounts.AccountListUsingGETAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [AccountListUsingGETRequest](../../Models/Operations/AccountListUsingGETRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[AccountListUsingGETResponse](../../Models/Operations/AccountListUsingGETResponse.md)**


## ConvertV4AccountIdToV5UsingGET

Convert V4 technical account identifier to V5

### Example Usage

```csharp
using Accounts;
using Accounts.Models.Shared;
using Accounts.Models.Operations;

var sdk = new AccountsSDK(security: new Security() {
        DecoupledAuth = "Bearer <YOUR_ACCESS_TOKEN_HERE>",
    });

ConvertV4AccountIdToV5UsingGETRequest req = new ConvertV4AccountIdToV5UsingGETRequest() {
    Signature = "<value>",
    XIBMClientId = "<value>",
    XIBMClientSecret = "<value>",
    XNordeaOriginatingDate = "<value>",
    XNordeaOriginatingHost = "<value>",
    Id = "<id>",
};

var res = await sdk.CustomerAccounts.ConvertV4AccountIdToV5UsingGETAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [ConvertV4AccountIdToV5UsingGETRequest](../../Models/Operations/ConvertV4AccountIdToV5UsingGETRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |


### Response

**[ConvertV4AccountIdToV5UsingGETResponse](../../Models/Operations/ConvertV4AccountIdToV5UsingGETResponse.md)**


## ConvertV5AccountIdToV4UsingGET

Convert V5 technical account identifier to V4

### Example Usage

```csharp
using Accounts;
using Accounts.Models.Shared;
using Accounts.Models.Operations;

var sdk = new AccountsSDK(security: new Security() {
        DecoupledAuth = "Bearer <YOUR_ACCESS_TOKEN_HERE>",
    });

ConvertV5AccountIdToV4UsingGETRequest req = new ConvertV5AccountIdToV4UsingGETRequest() {
    Signature = "<value>",
    XIBMClientId = "<value>",
    XIBMClientSecret = "<value>",
    XNordeaOriginatingDate = "<value>",
    XNordeaOriginatingHost = "<value>",
    Id = "<id>",
};

var res = await sdk.CustomerAccounts.ConvertV5AccountIdToV4UsingGETAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [ConvertV5AccountIdToV4UsingGETRequest](../../Models/Operations/ConvertV5AccountIdToV4UsingGETRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |


### Response

**[ConvertV5AccountIdToV4UsingGETResponse](../../Models/Operations/ConvertV5AccountIdToV4UsingGETResponse.md)**


## TransactionListUsingGET

Get account transactions

### Example Usage

```csharp
using Accounts;
using Accounts.Models.Shared;
using Accounts.Models.Operations;
using NodaTime;

var sdk = new AccountsSDK(security: new Security() {
        DecoupledAuth = "Bearer <YOUR_ACCESS_TOKEN_HERE>",
    });

TransactionListUsingGETRequest req = new TransactionListUsingGETRequest() {
    Signature = "<value>",
    XIBMClientId = "<value>",
    XIBMClientSecret = "<value>",
    XNordeaOriginatingDate = "<value>",
    XNordeaOriginatingHost = "<value>",
    Id = "<id>",
};

var res = await sdk.CustomerAccounts.TransactionListUsingGETAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [TransactionListUsingGETRequest](../../Models/Operations/TransactionListUsingGETRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[TransactionListUsingGETResponse](../../Models/Operations/TransactionListUsingGETResponse.md)**

