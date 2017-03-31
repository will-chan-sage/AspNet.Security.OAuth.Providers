using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;


namespace Mvc.Client
{
    public class AuthorizedRequirement : IAuthorizationRequirement
    {
        public AuthorizedRequirement(int age)
        {
            MinimumAge = age;
        }

        protected int MinimumAge { get; set; }
    }

    public class AuthorizedHandler : AuthorizationHandler<AuthorizedRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AuthorizedRequirement requirement)
        {
            context.Succeed(requirement);
            return Task.FromResult(0);
        }
    }
}
