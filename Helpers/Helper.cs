using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Helpers
{
    public static class Helper
    {
        public static string ConvertUrl(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                Uri output;

                if (!url.ToLower().StartsWith("mailto:") && !url.ToLower().StartsWith("tel:"))
                {
                    url = !url.StartsWith("http") && !url.Contains("media") ? "http://" + url : url;
                }

                if (Uri.TryCreate(url, UriKind.Absolute, out output))
                {
                    url = output.AbsoluteUri;
                }
            }

            return url;
        }

        public static string GetImageWithSlimsy(int width, int height, string url)
        {
            string src = string.Empty;

            if (!string.IsNullOrEmpty(url) && width != 0 && height != 0)
            {
                src += url;
                src += "?mode=max";
                src += "&slimmage=true";
                src += "&quality=80";
                src += "&width=" + width;
                src += "&height=" + height;
            }

            return src;
        }
    }
}
