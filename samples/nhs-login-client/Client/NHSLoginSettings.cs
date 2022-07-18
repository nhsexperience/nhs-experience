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

namespace NHS.Login.Client
{
    public class NHSLoginSettings
    {
        public static string Name = "NHSLogin";
        public string ClientId { get; set; }
        public string Subject { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string  Authority{get;set;}
        public IList<string> Scopes {get;set;} = new List<string>();

        public string Vtr {get;set;}

        public string PrivateKeyFile { get; set; }
    }
}