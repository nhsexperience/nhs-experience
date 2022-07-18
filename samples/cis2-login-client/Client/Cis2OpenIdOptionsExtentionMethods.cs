//  cis2-login-client
//  Open Government Licence 3.0 
// 
//   You must, acknowledge the source of the Information in your product or application by including or linking to any attribution statement 
//  specified by the Information Provider(s) and, where  possible, provide a link to this licence;  If the Information Provider does not 
//  provide a specific attribution statement, you must use  the following:   Contains public sector information licensed under the Open 
//  Government Licence v3.0.  If you are using Information from several Information Providers and listing multiple attributions is not 
//  practical in your product or application, you may  include a URI or hyperlink to a resource that contains the required attribution 
//  statements.  These are important conditions of this licence and if you fail to comply with them the rights granted to you under this
//   licence, or any similar licence granted by the  Licensor, will end automatically.

using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using NHS.Login.Client;


namespace Microsoft.Extensions.DependencyInjection
{
    public static class Cis2OpenIdOptionsExtentionMethods
    {
        private static Cis2Settings _settings;
        private const string _responseType =  "code";
        private const string _responseMode =  "form_post";

        public static AuthenticationBuilder AddCis2OpenId(this AuthenticationBuilder authenticationBuilder, Cis2Settings settings)
        {
            _settings = settings;
            authenticationBuilder.AddOpenIdConnect(options =>
            {
                SetOptions(options, settings);
            });
            return authenticationBuilder;
        }

        public static void SetOptions(OpenIdConnectOptions options, Cis2Settings settings)
        {
            options.RequireHttpsMetadata = true;
            options.ClientId = settings.ClientId;
            options.Authority = settings.Authority;
            options.ClientSecret = settings.Secret;

            options.ResponseType = _responseType;
            options.ResponseMode = _responseMode;
            //options.ResponseMode
            options.Scope.Clear();
            foreach(var scope in settings.Scopes)
                options.Scope.Add(scope);
            options.SaveTokens = true;
            options.Events = CreateOpenIdConnectEvents(settings);
        }

        private static OpenIdConnectEvents CreateOpenIdConnectEvents(Cis2Settings settings)
        {
                 
            return new OpenIdConnectEvents
            {
                OnRedirectToIdentityProvider = Redirect,
                OnAuthorizationCodeReceived = AuthorizationCodeReceived,
            };
        }

        private static Task Redirect(RedirectContext context)
        {
         
            return Task.CompletedTask;
        }

        private static Task AuthorizationCodeReceived(AuthorizationCodeReceivedContext context)
        {
        
            return Task.CompletedTask;
        }
    }
}