using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;

namespace MiddlewareDemo.Middleware
{
    public class DemoOptions : AuthenticationOptions, IOptions<DemoOptions>, IAuthorizationRequirement
    {
        public DemoOptions Value { get; }
    }
}
