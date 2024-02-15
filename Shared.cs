using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegAccGame
{
    internal class Shared
    {
        #region Captcha
        public class CaptchaResponse
        {
            public string image { get; set; }
            public string value { get; set; }
        }
        public class CatpchaBody
        {
            public string clientKey { get; set; }
            public Task_ task { get; set; }
            public string languagePool { get; set; }
        }
        public class CreateTaskResponse
        {
            public int errorId { get; set; }
            public long taskId { get; set; }
        }
        public class Task_
        {
            public string type { get; set; }
            public string body { get; set; }
            public bool phrase { get; set; }
            public bool @case { get; set; }
            public int numeric { get; set; }
            public bool math { get; set; }
            public int minLength { get; set; }
            public int maxLength { get; set; }
            public string comment { get; set; }
        }
        public class CaptchaResult
        {
            public int errorId { get; set; }
            public string status { get; set; }
            public Solution solution { get; set; }
            public string cost { get; set; }
            public string ip { get; set; }
            public int createTime { get; set; }
            public int endTime { get; set; }
            public int solveCount { get; set; }
        }
        public class Solution
        {
            public string text { get; set; }
        }
        public class CaptchaError
        {
            public int errorId { get; set; }
            public string errorCode { get; set; }
            public string errorDescription { get; set; }
        }
        #endregion

        #region Account 
        public class RegisterInfo
        {
            public string account { get; set; }
            public string password { get; set; }
            public string confirm_Password { get; set; }
            public object moneyPassword { get; set; }
            public string name { get; set; }
            public string countryCode { get; set; }
            public object mobile { get; set; }
            public object email { get; set; }
            public object sex { get; set; }
            public object birthday { get; set; }
            public object idNumber { get; set; }
            public object qqAccount { get; set; }
            public object groupBank { get; set; }
            public object bankName { get; set; }
            public object bankProvince { get; set; }
            public object bankCity { get; set; }
            public object bankAccount { get; set; }
            public string checkCodeEncrypt { get; set; }
            public string checkCode { get; set; }
            public bool isRequiredMoneyPassword { get; set; }
            public object dealerAccount { get; set; }
            public object parentAccount { get; set; }
        }
        public class RegisterResponse
        {
            public Error[] Error { get; set; }
            public int Code { get; set; }
            public Result Result { get; set; }
            public string ReplyTime { get; set; }
        }
        public class Error
        {
            public string Field { get; set; }
            public string Message { get; set; }
        }
        public class Result
        {
            public bool MemberRegisterVerifySwitch { get; set; }
            public int AvailableMinutes { get; set; }
            public Token Token { get; set; }
        }
        public class Token
        {
            public string AccessToken { get; set; }
            public string RefreshToken { get; set; }
        }
        public class Bank
        {
            public int Id { get; set; }
            public string Display { get; set; }
            public string Name { get; set; }
            public int Sort { get; set; }
            public int AccountFormat { get; set; }
        }
        public class Result_
        {
            public List<Bank> Banks { get; set; }
        }
        public class BankResponse
        {
            public List<object> Error { get; set; }
            public int Code { get; set; }
            public Result_ Result { get; set; }
            public DateTime ReplyTime { get; set; }
        }

        public class _Result
        {
            public string Account { get; set; }
            public bool IsLogin { get; set; }
            public bool IsTrial { get; set; }
            public double Balance { get; set; }
            public string IP { get; set; }
            public bool NeedChangePassword { get; set; }
            public bool IsBlock { get; set; }
        }

        public class InfoResponse
        {
            public List<object> Error { get; set; }
            public int Code { get; set; }
            public _Result Result { get; set; }
            public DateTime ReplyTime { get; set; }
        }

        #endregion
    }
}
