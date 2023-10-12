<!-- Start SDK Example Usage -->


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
<!-- End SDK Example Usage -->