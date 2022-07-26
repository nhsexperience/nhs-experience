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

﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using NHS.Login.Client;

namespace NHS.Login.Dotnet.Core6.Sample.Controllers
{

    public class HomeController
    {
        ClaimsReader _claimsReader;
        public HomeController(ClaimsReader claimsReader)
        {
            _claimsReader = claimsReader;
        }


        [HttpGet]
        [Authorize]
        public async IAsyncEnumerable<Claim> GetAsync()
        {
            await foreach (var claim in _claimsReader.GetClaimsAsync())
                yield return claim;
        }


    }
}
