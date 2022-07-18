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

using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace NHS.Login.Client
{
    public class TokenHelper
    {
        private static TimeSpan Expiry = TimeSpan.FromHours(1);
        Lazy<RSA> _rsa;

        private RSA CreateCreds()
        {
            var keyStr = File.ReadAllText(_settings.PrivateKeyFile); 
            var rsa = RSA.Create();
            rsa.ImportFromPem(keyStr);
            return rsa;
        }

        NHSLoginSettings _settings;
        public TokenHelper(NHSLoginSettings settings)
        {
            _settings = settings;
            var creds = CreateCreds();
            _rsa = new Lazy<RSA>(creds);

        }
        public string CreateClientAuthJwt()
        {
            
            var claims = new List<Claim>()
            {
                new Claim("sub", _settings.Subject),
                new Claim("jti", Guid.NewGuid().ToString()),
            };
            var payload = new JwtPayload(_settings.Issuer, _settings.Audience, claims, null, DateTime.Now.Add(Expiry), DateTime.Now);

            var credentials= new SigningCredentials(new RsaSecurityKey(_rsa.Value), SecurityAlgorithms.RsaSha512);
            var header = new JwtHeader(credentials);
            var token = new JwtSecurityToken(header, payload);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

