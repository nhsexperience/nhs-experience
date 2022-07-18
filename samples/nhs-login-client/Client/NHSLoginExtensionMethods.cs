//  nhs-login-client
//  Open Government Licence 3.0 
// 
//   You must, acknowledge the source of the Information in your product or application by including or linking to any attribution statement 
//  specified by the Information Provider(s) and, where  possible, provide a link to this licence;  If the Information Provider does not 
//  provide a specific attribution statement, you must use  the following:   Contains public sector information licensed under the Open 
//  Government Licence v3.0.  If you are using Information from several Information Providers and listing multiple attributions is not 
//  practical in your product or application, you may  include a URI or hyperlink to a resource that contains the required attribution 
//  statements.  These are important conditions of this licence and if you fail to comply with them the rights granted to you under this
//   licence, or any similar licence granted by the  Licensor, will end automatically.

using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using NHS.Login.Client;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class NHSLoginExtensionMethods
    {
        public static WebApplicationBuilder AddNHSLogin(this WebApplicationBuilder builder )
        {
            builder.Services.AddHttpClient();
            builder.Services.Configure<NHSLoginSettings>(builder.Configuration.GetSection(NHSLoginSettings.Name));
            builder.Services.AddTransient<ClaimsReader>();
            var conf = new NHSLoginSettings();
            builder.Configuration.Bind(NHSLoginSettings.Name, conf);

            builder.Services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            })
            .AddCookie()
            .AddNhsLoginOpenId(conf);
            return builder;
        }
    }
}