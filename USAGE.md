<!-- Start SDK Example Usage [usage] -->
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