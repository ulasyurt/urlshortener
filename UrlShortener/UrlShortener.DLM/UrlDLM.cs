using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlShortener.DBM;

namespace UrlShortener.DLM
{
    public class UrlDLM
    {
        public string getEncodedUrl(string longUrl)
        {
            try
            {
                using (var dbContext = new DBM.UrlShortenerEntities())
                {
                    var url = new UrlShortener.DBM.url();
                    url.LongUrl = longUrl;
                    dbContext.url.Add(url);

                    dbContext.SaveChanges();

                    return Base.encodeBase62(url.Id);
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public string getDecodedUrl(string shortUrl)
        {
            try
            {
                var urlId = Base.decodeBase62(shortUrl);

                using (var dbContext = new DBM.UrlShortenerEntities())
                {
                    var url = dbContext.url.FirstOrDefault(x => x.Id == urlId);
                    if (url != null)
                    {
                        return url.LongUrl;
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public List<Base.UrlListInnerModel> getUrlList()
        {
            try
            {


                using (var dbContext = new DBM.UrlShortenerEntities())
                {
                    var urlList = dbContext.url.OrderByDescending(x=>x.Id).ToList();
                    if (urlList != null && urlList.Count() > 0)
                    {
                        var newList = new List<Base.UrlListInnerModel>();
                        foreach (var item in urlList)
                        {
                            newList.Add(new Base.UrlListInnerModel
                            {
                                Id = item.Id,
                                ShortUrl = Base.encodeBase62(item.Id),
                                LongUrl = item.LongUrl
                            });
                        }
                        return newList;
                    }
                    else
                    {
                        return new List<Base.UrlListInnerModel>();
                    }
                }
            }
            catch (Exception ex)
            {
                return new List<Base.UrlListInnerModel>();
            }
        }
    }
}
