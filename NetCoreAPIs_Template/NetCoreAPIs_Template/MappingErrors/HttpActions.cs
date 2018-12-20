using Microsoft.AspNetCore.Mvc;
using NetCoreAPIs_Template.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.MappingErrors
{
    public static class HttpActions
    {
        public static IActionResult CustomResult(HttpStatusCode statuscode, object data)
        {
            return new HttpActionResult((int)statuscode, data);
        }

        public static OperationStatus GetResponse(this ErrorCodes enumError, string orderRef = "", string value = "")
        {
            OperationStatus response = new OperationStatus
            {
                IsSuccess = enumError.GetSuccessCode(),
                Code = enumError.GetErrorCode(),
                Description = enumError.GetErrorMessage(value),
                OrderRef = orderRef,
                StatusCode = enumError.GetHttpStatusCode()
            };
            return response;
        }

        #region private method
        private static bool GetSuccessCode(this ErrorCodes enumError)
        {
            if ((int)enumError >= 2000 && (int)enumError < 3000)
                return true;
            return false;
        }

        private static string GetErrorCode(this ErrorCodes enumError)
        {
            return ((int)enumError).ToString();
        }

        private static string GetErrorMessage(this ErrorCodes enumError, string value)
        {
            string Description = String.Empty;
            string Value = value;

            switch (enumError)
            {
                #region 200-299 : Success Status
                case ErrorCodes.Success:
                    Description = string.Format("{0} is Success", Value);
                    break;
                case ErrorCodes.CreatedSuccess:
                    Description = string.Format("{0} is Success", Value);
                    break;
                #endregion 200-299 : Success Status

                #region 400 Bad Request
                case ErrorCodes.BadRequest:
                    Description = string.Format("The Request {0} must not be null or empty", Value);
                    break;
                case ErrorCodes.InvalidRequest:
                    Description = string.Format("The Request {0} is Invalid", Value);
                    break;
                #endregion 400 Bad Request

                #region 401 Unauthorized
                case ErrorCodes.AccountAccessDenied:
                    Description = string.Format("The {0} is Access Denied", Value);
                    break;
                case ErrorCodes.AccountAuthenFailed:
                    Description = string.Format("The Account is {0} Failed", Value);
                    break;
                case ErrorCodes.AccountNotFound:
                    Description = string.Format("The {0} is Untrusted or Not Found", Value);
                    break;
                case ErrorCodes.AccountUntrustedOrInvalid:
                    Description = string.Format("The {0} is Untrusted or Invalid", Value);
                    break;
                case ErrorCodes.AccountTemporarilySuspended:
                    Description = string.Format("The {0} is Untrusted and has been Temporarily Suspended", Value);
                    break;
                case ErrorCodes.AccountExpiredOrNotYetValid:
                    Description = string.Format("The {0} is Expired or must not be yet valid", Value);
                    break;
                case ErrorCodes.AccountTerminated:
                    Description = string.Format("The {0} has Terminated", Value);
                    break;
                #endregion 401 Unauthorized

                #region 403 Forbidden
                case ErrorCodes.DataMissingOrInvalidParameter:
                    Description = string.Format("The Parameter {0} is Missing Or Invalid ", Value);
                    break;
                case ErrorCodes.DataExisted:
                    Description = string.Format("The {0} is Already Existed", Value);
                    break;
                case ErrorCodes.DataAlreadyInUse:
                    Description = string.Format("The {0} is Already Use", Value);
                    break;
                case ErrorCodes.DataUntrustedOrInvalid:
                    Description = string.Format("The {0} is Untrusted or Invalid", Value);
                    break;
                case ErrorCodes.DataExpiredOrNotYetValid:
                    Description = string.Format("The {0} has Expired or must not be yet valid", Value);
                    break;
                case ErrorCodes.DataConflicted:
                    Description = string.Format("The {0} is conflicted", Value);
                    break;
                #endregion 403 Forbidden

                #region 404 Not Found
                case ErrorCodes.DataNotFound:
                    Description = string.Format("The {0} is Data Not Found or Invalid", Value);
                    break;
                case ErrorCodes.DataHasTerminated:
                    Description = string.Format("The {0} has been Terminated", Value);
                    break;
                case ErrorCodes.DataInvalid:
                    Description = string.Format("The {0} is Data Invalid", Value);
                    break;
                #endregion 404 Not Found

                #region 405 Method Not Allowed
                case ErrorCodes.MethodNotAllowed:
                    Description = string.Format("Method Not Allowed");
                    break;
                #endregion 405 Method Not Allowed

                #region 500 Internal Server Error
                case ErrorCodes.InternalServerError:
                    Description = string.Format("Internal Server Error");
                    break;
                case ErrorCodes.UnknowError:
                    Description = string.Format("Unknow Error");
                    break;
                #endregion 500 Internal Server Error

                #region 520-530	Andomeda

                #endregion 520-530	Andomeda

                //case ErrorCodes.xxxxx: Description = string.Format("{0} xxxxxxxxxxx", Value); break;
                //case ErrorCodes.xxxxx: Description = string.Format("{0} xxxxxxxxxxx", Value); break;
                //case ErrorCodes.xxxxx: Description = string.Format("{0} xxxxxxxxxxx", Value); break;
                //case ErrorCodes.xxxxx: Description = string.Format("{0} xxxxxxxxxxx", Value); break;
                //case ErrorCodes.xxxxx: Description = string.Format("{0} xxxxxxxxxxx", Value); break;
                //case ErrorCodes.xxxxx: Description = string.Format("{0} xxxxxxxxxxx", Value); break;
                //case ErrorCodes.xxxxx: Description = string.Format("{0} xxxxxxxxxxx", Value); break;
                //case ErrorCodes.xxxxx: Description = string.Format("{0} xxxxxxxxxxx", Value); break;
                //case ErrorCodes.xxxxx: Description = string.Format("{0} xxxxxxxxxxx", Value); break;

                default: Description = "Unknow Description Error!!"; break;
            }
            return Description.Replace("  ", " ");
        }

        private static HttpStatusCode GetHttpStatusCode(this ErrorCodes enumCode)
        {
            HttpStatusCode Code = new HttpStatusCode();
            foreach (HttpStatusCode o in Enum.GetValues(typeof(HttpStatusCode)))
            {
                if (((int)o).Equals((enumCode.GetIntIndex3Digit())))
                    Code = o;
            }
            return Code;
        }

        private static int GetIntIndex3Digit(this ErrorCodes eValue)
        {
            return Convert.ToInt32(((int)eValue).ToString().Substring(0, 3));
        }
        #endregion

    }
}
