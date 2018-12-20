using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.MappingErrors
{
    //100-199 : informational status
    //200-299 : success status
    //300-399 : redirection status
    //400-499 : client errors
    //500-599 : server errors
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ErrorCodes : int
    {
        #region 200-299 : Success Status
        /// <summary>The Message 'Success' is Status of HTTP</summary>
        /// <summary>การดำเนินการที่ร้องขอสำเร็จแล้ว</summary>
        [Description("Success")]
        Success = 2000,

        /// <summary>The Message 'Created Success' is Status of HTTP</summary>
        /// <summary>การดำเนินการที่ร้องขอได้ดำเนินการแล้ว</summary>
        [Description("Created Success")]
        CreatedSuccess = 2010,
        #endregion 200-299 : Success Status

        #region 400 Bad Request
        /// <summary>The Message 'Bad Request' is Status of HTTP</summary>
        /// <summary>การร้องขอจากเครื่องลูกข่ายไม่สามารถทำตามการร้องขอได้</summary>
        [Description("Bad Request")]
        BadRequest = 4000,

        /// <summary>The Message 'Invalid Request' is Status of HTTP</summary>
        /// <summary>การร้องขอจากเครื่องลูกข่ายความผิดพลาดทางไวยากรณ์</summary>
        [Description("Invalid Request")]
        InvalidRequest = 4001,
        #endregion 400 Bad Request

        #region 401 Unauthorized
        /// <summary>The Message 'Account Access Denied' is Status of HTTP</summary>
        /// <summary>การร้องขอจากเครื่องลูกข่ายจำเป็นต้องทำการพิสูจน์ตัวตน</summary>
        [Description("Account Access Denied")]
        AccountAccessDenied = 4010,

        /// <summary>The Message 'Account Invalid Request' is Status of HTTP</summary>
        /// <summary>การพิสูจน์จากเครื่องลูกข่ายมีความผิดพลาด</summary>
        [Description("Account Authen Failed")]
        AccountAuthenFailed = 4011,

        /// <summary>The Message 'Account Untrusted Or Not Found' is Status of HTTP</summary>
        /// <summary>ไม่พบข้อมูลการพิสูจน์ตัวตนจากเครื่องลูกข่าย</summary>
        [Description("Account Not Found")]
        AccountNotFound = 4012,

        /// <summary>The Message 'Account Untrusted Or Invalid' is Status of HTTP</summary>
        /// <summary>ข้อมูลการพิสูจน์ตัวตนจากเครื่องลูกข่ายมีความผิดพลาด</summary>
        [Description("Account Untrusted or Invalid")]
        AccountUntrustedOrInvalid = 4013,

        /// <summary>The Message 'Account Untrusted and has been Temporarily Suspended' is Status of HTTP</summary>
        /// <summary>บัญชีไม่น่าเชื่อถือและถูกระงับชั่วคราว</summary>
        [Description("Account has been Temporarily Suspended")]
        AccountTemporarilySuspended = 4014,

        /// <summary>The Message 'Account Expired or must not be yet valid' is Status of HTTP</summary>
        /// <summary>บัญชีหมดอายุแล้วหรือยังไม่ถูกต้อง</summary>
        [Description("Account Expired or must not be yet valid")]
        AccountExpiredOrNotYetValid = 4015,

        /// <summary>The Message 'Account has Terminated' is Status of HTTP</summary>
        /// <summary>บัญชีถูกยุติการใช้งานแล้ว</summary>
        [Description("Account has Terminated")]
        AccountTerminated = 4016,
        #endregion 401 Unauthorized

        #region 403 Forbidden
        /// <summary>The Message 'Client Data is Missing Or Invalid Parameter' is Status of HTTP</summary>
        /// <summary>ข้อมูลลูกค้าหายไปหรือพารามิเตอร์ไม่ถูกต้อง</summary>
        [Description("Client Data is Missing Or Invalid Parameter")]
        DataMissingOrInvalidParameter = 4030,

        /// <summary>The Message 'Client Data is Already Existed' is Status of HTTP</summary>
        /// <summary>ข้อมูลลูกค้ามีอยู่แล้ว</summary>
        [Description("Client Data is Already Existed")]
        DataExisted = 4031,

        /// <summary>The Message 'Client Data is Already in use' is Status of HTTP</summary>
        /// <summary>ข้อมูลลูกค้าถูกใช้แล้ว</summary>
        [Description("Client Data is Already in use")]
        DataAlreadyInUse = 4032,

        /// <summary>The Message 'Client Data is Untrusted or Invalid' is Status of HTTP</summary>
        /// <summary>ข้อมูลลูกค้าไม่น่าเชื่อถือหรือไม่ถูกต้อง</summary>
        [Description("Client Data is Untrusted or Invalid")]
        DataUntrustedOrInvalid = 4033,

        /// <summary>The Message 'Client Data has Expired or must not be Yet Valid' is Status of HTTP</summary>
        /// <summary>ข้อมูลลูกค้าหมดอายุหรือยังไม่ถูกต้อง</summary>
        [Description("Client Data has Expired or must not be Yet Valid")]
        DataExpiredOrNotYetValid = 4034,

        /// <summary>The Message 'Client Data is conflicted' is Status of HTTP</summary>
        /// <summary>ข้อมูลในระบบมีความขัดแย้งกัน</summary>
        [Description("Client Data is conflicted")]
        DataConflicted = 4035,

        /// <summary>The Message 'Still In Proscess' is Status of HTTP</summary>
        /// <summary>กำลังประมวลผลอยู่</summary>
        [Description("Still In Proscess")]
        StillInProscess = 4036,

        #endregion 403 Forbidden

        #region 404 Not Found
        /// <summary>The Message 'Data Not Found' is Status of HTTP</summary>
        /// <summary>ไม่พบข้อมูล</summary>
        [Description("Data Not Found")]
        DataNotFound = 4040,

        /// <summary>The Message 'Data has Terminated' is Status of HTTP</summary>
        /// <summary>ข้อมูลถูกยกเลิกแล้ว</summary>
        [Description("Data has Terminated")]
        DataHasTerminated = 4041,

        /// <summary>The Message 'Data has Invalid' is Status of HTTP</summary>
        /// <summary>ข้อมูลไม่น่าเชื่อถือหรือไม่ถูกต้อง</summary>
        [Description("Data Invalid")]
        DataInvalid = 4042,
        #endregion 404 Not Found

        #region 405 Method Not Allowed
        /// <summary>The Message 'Method Not Allowed' is Status of HTTP</summary>
        /// <summary>เครื่องลูกข่ายใช้คำสั่งที่ทรัพยากรนั้นไม่รองรับ</summary>
        [Description("Method Not Allowed")]
        MethodNotAllowed = 4050,
        #endregion 405 Method Not Allowed

        #region 500 Internal Server Error
        /// <summary>The Message 'Internal Server Error' is Status of HTTP</summary>
        /// <summary>เกิดข้อผิดพลาดภายในเซิร์ฟเวอร์</summary>
        [Description("Internal Server Error")]
        InternalServerError = 5000,

        /// <summary>The Message 'Unknow Error' is Status of HTTP</summary>
        /// <summary>ข้อผิดพลาดที่ไม่รู้จัก</summary>
        [Description("Unknow Error")]
        UnknowError = 5009,
        #endregion 500 Internal Server Error

        #region 520-530	Andomeda
        ///// <summary>The Message 'Authen SDK Service Error' is Status of HTTP</summary>
        ///// <summary>ข้อผิดพลาดการยืนยันตัวตนของ SDK</summary>
        //[Description("Authen SDK Service Error")]
        //AuthenSDKSreviceError = 5201,

        ///// <summary>The Message 'OTP Service Error' is Status of HTTP</summary>
        ///// <summary>ข้อผิดพลาด OTP</summary>
        //[Description("OTP Service Error")]
        //OTPServiceError = 5202,

        ///// <summary>The Message 'SMS Service Error' is Status of HTTP</summary>
        ///// <summary>ข้อผิดพลาดของ SMS</summary>
        //[Description("SMS Service Error")]
        //SMSServiceError = 5203,

        ///// <summary>The Message 'Notification Service Error' is Status of HTTP</summary>
        ///// <summary>ข้อผิดพลาดของ Notification</summary>
        //[Description("Notification Service Error")]
        //NotificationServiceError = 5204,

        #endregion 520-530	Andomeda

    }//End Class

}
