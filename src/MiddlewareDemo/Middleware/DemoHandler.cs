using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features.Authentication;

namespace MiddlewareDemo.Middleware
{
    public class DemoHandler : AuthenticationHandler<DemoOptions>
    {
        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            throw new NotImplementedException();
        }

        protected override Task HandleSignInAsync(SignInContext context)
        {
            throw new NotImplementedException();
        }

        protected override Task HandleSignOutAsync(SignOutContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Override this method to deal with 401 challenge concerns, if an authentication scheme in question
        ///             deals an authentication interaction as part of it's request flow. (like adding a response header, or
        ///             changing the 401 result to 302 of a login page or external sign-in location.)
        /// </summary>
        /// <param name="context"/>
        /// <returns>
        /// True if no other handlers should be called
        /// </returns>
        protected override Task<bool> HandleUnauthorizedAsync(ChallengeContext context)
        {
            throw new NotImplementedException();
        }
    }
}
