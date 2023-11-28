<!-- Start SDK Example Usage [usage] -->
```csharp
using Accounts;
using Accounts.Models.Shared;
using Accounts.Models.Operations;

var sdk = new Accounts(
    security: new Security() {
        DecoupledAuth = "",
        OAuth2 = "",
    }
);

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
<!-- End SDK Example Usage [usage] -->