using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreAPIs_Template.MappingErrors;
using NetCoreAPIs_Template.Models.Auth;
using NetCoreAPIs_Template.Process;

namespace NetCoreAPIs_Template.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [AllowAnonymous]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(SignInResponse))]
        public IActionResult SignIn(SignInRequest req)
        {
            AuthProcess process = new AuthProcess(_logger);
            SignInResponse resp = process.SignInProcess(req);
            return HttpActions.CustomResult(resp.OperationStatus.StatusCode, resp);
        }

    }
}