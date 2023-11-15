# accounts

<div align="left">
    <a href="https://speakeasyapi.dev/"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
    <a href="https://github.com/speakeasy-sdks/nordtest.git/actions"><img src="https://img.shields.io/github/actions/workflow/status/speakeasy-sdks/nordtest/speakeasy_sdk_generation.yml?style=for-the-badge" /></a>
    
</div>

<!-- Start SDK Installation -->
## SDK Installation

### Nuget

```bash
dotnet add package accounts
```
<!-- End SDK Installation -->

## SDK Example Usage
<!-- Start SDK Example Usage -->
### Example

```csharp
using Accounts;
using Accounts.Models.Shared;
using Accounts.Models.Operations;

var sdk = new Accounts();

var res = await sdk.CustomerAccounts.AccountDetailsUsingGETAsync(new AccountDetailsUsingGETRequest() {
    Signature = "string",
    XIBMClientId = "string",
    XIBMClientSecret = "string",
    XNordeaOriginatingDate = "string",
    XNordeaOriginatingHost = "string",
    Id = "<ID>",
});

// handle response
```
<!-- End SDK Example Usage -->

<!-- Start SDK Available Operations -->
## Available Resources and Operations


### [CustomerAccounts](docs/sdks/customeraccounts/README.md)

* [AccountDetailsUsingGET](docs/sdks/customeraccounts/README.md#accountdetailsusingget) - Get account details by account id
* [AccountListUsingGET](docs/sdks/customeraccounts/README.md#accountlistusingget) - Get list of accounts
* [ConvertV4AccountIdToV5UsingGET](docs/sdks/customeraccounts/README.md#convertv4accountidtov5usingget) - Convert V4 technical account identifier to V5
* [ConvertV5AccountIdToV4UsingGET](docs/sdks/customeraccounts/README.md#convertv5accountidtov4usingget) - Convert V5 technical account identifier to V4
* [TransactionListUsingGET](docs/sdks/customeraccounts/README.md#transactionlistusingget) - Get account transactions
<!-- End SDK Available Operations -->

<!-- Start Dev Containers -->

<!-- End Dev Containers -->

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
