
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Accounts
{
    using Accounts.Models.Errors;
    using Accounts.Models.Shared;
    using Accounts.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Accounts API: Nordea Account Information Services API v5
    /// </summary>
    public interface IAccountsSDK
    {

        /// <summary>
        /// Customer accounts
        /// </summary>
        public ICustomerAccounts CustomerAccounts { get; }
    }

    public class SDKConfig
    {
        /// <summary>
        /// List of server URLs available to the SDK.
        /// </summary>
        public static readonly string[] ServerList = {
            "https:////api.nordeaopenbanking.com/personal/",
        };

        public string serverUrl = "";
        public int serverIndex = 0;

        public string GetTemplatedServerDetails()
        {
            if (!String.IsNullOrEmpty(this.serverUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.serverUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.serverIndex], new Dictionary<string, string>());
        }
    }

    /// <summary>
    /// Accounts API: Nordea Account Information Services API v5
    /// </summary>
    public class AccountsSDK: IAccountsSDK
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "0.9.0";
        private const string _sdkGenVersion = "2.295.1";
        private const string _openapiDocVersion = "5.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.9.0 2.295.1 5.0 Accounts";
        private string _serverUrl = "";
        private int _serverIndex = 0;
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;
        public ICustomerAccounts CustomerAccounts { get; private set; }

        public AccountsSDK(Security? security = null, Func<Security>? securitySource = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null)
        {
            if (serverIndex != null)
            {
                if (serverIndex.Value < 0 || serverIndex.Value >= SDKConfig.ServerList.Length)
                {
                    throw new Exception($"Invalid server index {serverIndex.Value}");
                }
                _serverIndex = serverIndex.Value;
            }

            if (serverUrl != null)
            {
                if (urlParams != null)
                {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _defaultClient = new SpeakeasyHttpClient(client);

            if(securitySource != null)
            {
                _securitySource = securitySource;
            }
            else if(security != null)
            {
                _securitySource = () => security;
            }

            SDKConfiguration = new SDKConfig()
            {
                serverIndex = _serverIndex,
                serverUrl = _serverUrl
            };

            CustomerAccounts = new CustomerAccounts(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}
