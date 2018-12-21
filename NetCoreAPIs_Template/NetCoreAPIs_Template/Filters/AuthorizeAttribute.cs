using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using NetCoreAPIs_Template.Base;
using NetCoreAPIs_Template.MappingErrors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.Filters
{
    public class AuthorizeAttribute : AuthorizeFilter
    {
        public AuthorizeAttribute(AuthorizationPolicy policy) : base(policy)
        {
        }

        public override Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.User.Identity.IsAuthenticated && !context.Filters.OfType<AllowAnonymousFilter>().Any())
            {
                UnauthorizedResponse resp = new UnauthorizedResponse()
                {
                    OperationStatus = HttpActions.GetResponse(ErrorCodes.AccountAuthenFailed)
                };

                return HttpActions.CustomResult(resp.OperationStatus.StatusCode, resp).ExecuteResultAsync(context);
            }
            return base.OnAuthorizationAsync(context);
        }
    }

    #region private
    public class UnauthorizedResponse : ResponseBase
    {
    }
    #endregion
}
