# accounts

<div align="left">
    <a href="https://speakeasyapi.dev/"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
    <a href="https://github.com/speakeasy-sdks/nordtest.git/actions"><img src="https://img.shields.io/github/actions/workflow/status/speakeasy-sdks/nordtest/speakeasy_sdk_generation.yml?style=for-the-badge" /></a>
    
</div>

<!-- Start SDK Installation [installation] -->
## SDK Installation

### Nuget

```bash
dotnet add package accounts
```
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

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
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

### [CustomerAccounts](docs/sdks/customeraccounts/README.md)

* [AccountDetailsUsingGET](docs/sdks/customeraccounts/README.md#accountdetailsusingget) - Get account details by account id
* [AccountListUsingGET](docs/sdks/customeraccounts/README.md#accountlistusingget) - Get list of accounts
* [ConvertV4AccountIdToV5UsingGET](docs/sdks/customeraccounts/README.md#convertv4accountidtov5usingget) - Convert V4 technical account identifier to V5
* [ConvertV5AccountIdToV4UsingGET](docs/sdks/customeraccounts/README.md#convertv5accountidtov4usingget) - Convert V5 technical account identifier to V4
* [TransactionListUsingGET](docs/sdks/customeraccounts/README.md#transactionlistusingget) - Get account transactions
<!-- End Available Resources and Operations [operations] -->

<!-- Start Server Selection [server] -->
## Server Selection

## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: number` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| # | Server | Variables |
| - | ------ | --------- |
| 0 | `https:////api.nordeaopenbanking.com/personal/` | None |




### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: str` optional parameter when initializing the SDK client instance. For example:
<!-- End Server Selection [server] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security schemes globally:

| Name            | Type            | Scheme          |
| --------------- | --------------- | --------------- |
| `DecoupledAuth` | oauth2          | OAuth2 token    |
| `OAuth2`        | oauth2          | OAuth2 token    |

You can set the security parameters through the `security` optional parameter when initializing the SDK client instance. The selected scheme will be used by default to authenticate with the API for all operations that support it. For example:
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
<!-- End Authentication [security] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release!

### SDK Created by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
