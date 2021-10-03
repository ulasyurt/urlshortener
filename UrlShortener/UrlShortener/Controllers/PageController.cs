using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrlShortener.Base;

namespace UrlShortener.Controllers
{
    public class PageController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            ViewData["ApiUrl"] = Statics.ApiUrl;
            return View();
        }
        
        [Route("{shortUrl}")]
        public ActionResult Dispatch(string shortUrl)
        {
            ViewData["ApiUrl"] = Statics.ApiUrl;
            ViewData["ShortUrl"] = shortUrl;
            return View();
        }
    }
}