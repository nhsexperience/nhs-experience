// Program.cs - nhs-login-client
//  Open Government Licence 3.0 
// 
//   You must, acknowledge the source of the Information in your product or application by including or linking to any attribution statement 
//  specified by the Information Provider(s) and, where  possible, provide a link to this licence;  If the Information Provider does not 
//  provide a specific attribution statement, you must use  the following:   Contains public sector information licensed under the Open 
//  Government Licence v3.0.  If you are using Information from several Information Providers and listing multiple attributions is not 
//  practical in your product or application, you may  include a URI or hyperlink to a resource that contains the required attribution 
//  statements.  These are important conditions of this licence and if you fail to comply with them the rights granted to you under this
//   licence, or any similar licence granted by the  Licensor, will end automatically.

using System.Collections.Generic;
using System.Net.Http;
using IdentityModel.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace NHS.Login.Client
{
    public class ClaimsReader
    {
        IHttpContextAccessor _accessor;
        NHSLoginSettings _settings;
        IHttpClientFactory _clientFactory;
        public ClaimsReader(
            IHttpClientFactory clientFactory,
            IHttpContextAccessor accessor,
            IOptions<NHSLoginSettings> settings)
        {
            _clientFactory = clientFactory;
            _settings = settings.Value;
            _accessor = accessor;
        }
        public async IAsyncEnumerable<Claim> GetClaimsAsync()
        {

            var idtoken = await GetIdTokenAsync();
            var accessToken = await GetTokenAsync();
            var response = await GetUserInfoAsync(accessToken);
            foreach (var claim in response.Claims)
                yield return claim;
        }

        private async Task<string> GetTokenAsync()
        {
            return await _accessor.HttpContext.GetTokenAsync("access_token");
        }

        private async Task<string> GetIdTokenAsync()
        {
            return await _accessor.HttpContext.GetTokenAsync("id_token");
        }

        private async Task<UserInfoResponse> GetUserInfoAsync(string accessToken)
        {
            var client = _clientFactory.CreateClient();
            var disco = await client.GetDiscoveryDocumentAsync(_settings.Authority);
            return await client.GetUserInfoAsync(new UserInfoRequest
            {
                Address = _settings.Authority + "userinfo",
                Token = accessToken
            });
        }
    }
}
