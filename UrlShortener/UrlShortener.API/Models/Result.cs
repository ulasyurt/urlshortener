using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UrlShortener.API.Models
{
    public class Result
    {
        public string Message { get; set; }
        public string Exception { get; set; }
        public bool Success { get; set; }
        public object ResultList { get; set; }

        public void SetSuccess()
        {
            Success = true;
            Message = "";
        }

        public void SetSuccess(object T) 
        {
            Success = true;
            Message = "";
            ResultList = T;
        }

        public void SetSuccess(string message)
        {
            Success = true;
            Message = message;
        }

        public void SetErrror()
        {
            Success = false;
            Message = "";
            Exception = "";
        }
        public void SetErrror(string message)
        {
            Success = false;
            Message = message;
            Exception = "";
        }
        public void SetErrror(Exception ex)
        {
            Success = false;
            Exception = ex.Message;
            Message = "Beklenmeyen bir hata oluştu.";
        }
    }
}