using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UrlShortener.API.Models
{
    public class Request
    {
        public string LongUrl { get; set; }
        public string ShortUrl { get; set; }
    }
}