using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlShortener.DLM
{
    public class Base
    {
        public static string base62Characters = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public class UrlListInnerModel
        {
            public int Id { get; set; }
            public string ShortUrl { get; set; }
            public string LongUrl { get; set; }
        }

        public static string encodeBase62(int Id)
        {
            try
            {
                string result = "";

                while (Id > 0)
                {
                    int index = Id % 62;
                    result += base62Characters[index];
                    Id = Convert.ToInt32(Math.Floor(Convert.ToDecimal(Id / 62)));
                }

                return result;
            }
            catch
            {
                return "";
            }

        }

        public static long decodeBase62(string shortUrl)
        {
            try
            {
                long Id = 0;

                for (int i = 0; i < shortUrl.Length; i++)
                {
                    int index = base62Characters.IndexOf(shortUrl[i]);
                    Id += index * (long)Math.Pow(62, i);
                }

                return Id;
            }
            catch
            {
                return 0;
            }

        }
    }
}
