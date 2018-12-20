using Microsoft.Extensions.Logging;
using NetCoreAPIs_Template.MappingErrors;
using NetCoreAPIs_Template.Models.Auth;
using NetCoreAPIs_Template.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.Process
{
    public class AuthProcess
    {
        private readonly ILogger _logger;
        public AuthProcess(ILogger logger)
        {
            _logger = logger;
        }

        public SignInResponse SignInProcess(SignInRequest req)
        {
            SignInResponse resp = new SignInResponse();
            try
            {
                //Check user in database logic
                if (true)
                {
                    JwtUtil jwt = new JwtUtil();
                    string token =  jwt.CreateJwtToken(req.username);

                    resp = new SignInResponse()
                    {
                        username = req.username,
                        name = "Mock user",
                        token = token,
                        OperationStatus = HttpActions.GetResponse(ErrorCodes.Success)
                    };
                }
                else
                {
                    resp = new SignInResponse()
                    {
                        OperationStatus = HttpActions.GetResponse(ErrorCodes.AccountNotFound)
                    };
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggingEvents.SignIn, ex, LoggingMessages.getFormat, req, resp);
            }
            finally
            {
                _logger.LogInformation(LoggingEvents.SignIn, LoggingMessages.getFormat, req, resp);
            }
            return resp;
        }
    }
}
