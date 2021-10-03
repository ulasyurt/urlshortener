using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using UrlShortener.API.Models;

namespace UrlShortener.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        [HttpPost, Route("generator")]
        public Result getEncodedUrl(Request request)
        {
            var result = new Result();
            try
            {
                string pattern = @"https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)";
                Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

                if (string.IsNullOrWhiteSpace(request.LongUrl))
                {
                    result.SetErrror("Lütfen kısaltmak istediğiniz linki giriniz.");
                }
                else if (!reg.IsMatch(request.LongUrl))
                {
                    result.SetErrror("Lütfen geçerli bir URL giriniz.");
                }
                else
                {
                    var dlm = new DLM.UrlDLM();

                    var shortUrl = dlm.getEncodedUrl(request.LongUrl);
                    result.SetSuccess(shortUrl);
                }
            }
            catch (Exception ex)
            {
                result.SetErrror("Beklenmeyen bir hata oluştu.");
            }
            return result;
        }

        [HttpPost, Route("dispatch")]
        public Result getDecodedUrl(Request request)
        {
            var result = new Result();
            try
            {
                if (string.IsNullOrWhiteSpace(request.ShortUrl))
                {
                    result.SetErrror("Lütfen bulmak istediğiniz linki giriniz.");
                }
                else
                {
                    var dlm = new DLM.UrlDLM();

                    var longUrl = dlm.getDecodedUrl(request.ShortUrl);

                    if (string.IsNullOrWhiteSpace(longUrl))
                    {
                        result.SetErrror("Beklenmeyen bir hata oluştu.");
                    }
                    else
                    {
                        result.SetSuccess(longUrl);
                    }
                }
            }
            catch (Exception ex)
            {
                result.SetErrror("Beklenmeyen bir hata oluştu.");
            }
            return result;
        }

        [HttpGet, Route("get-url-list")]
        public Result getUrlList()
        {
            var result = new Result();
            try
            {
                var dlm = new DLM.UrlDLM();

                var urlList = dlm.getUrlList();

                result.SetSuccess(urlList);

            }
            catch (Exception ex)
            {
                result.SetErrror("Beklenmeyen bir hata oluştu.");
            }
            return result;
        }

    }
}
