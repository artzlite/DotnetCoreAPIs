using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Logging;
using NetCoreAPIs_Template.Base;
using NetCoreAPIs_Template.MappingErrors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.Filters
{
    public class ValidateModelStateAttribute : ActionFilterAttribute
    {

        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {

                Dictionary<string, string> errorList = context.ModelState.ToDictionary(
                        kvp => kvp.Key,
                        kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).FirstOrDefault()
                    );

                ValidateModelStateResponse resp = new ValidateModelStateResponse()
                {
                    ModelState = errorList,
                    OperationStatus = HttpActions.GetResponse(ErrorCodes.DataMissingOrInvalidParameter)
                };

                return HttpActions.CustomResult(resp.OperationStatus.StatusCode, resp).ExecuteResultAsync(context);
            }
            return base.OnActionExecutionAsync(context, next);
        }

        #region private
        public class ValidateModelStateResponse : ResponseBase
        {
            public Dictionary<string, string> ModelState { get; set; }
        }
        #endregion
    }
}
