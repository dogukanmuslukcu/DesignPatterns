using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class EndPointBuilder
    {
        private readonly StringBuilder sbUrl = new ();
        private readonly StringBuilder sbParam = new();
        private const char defaultDelimeter = '/';
        public string BaseUrl { get; set; }
        public EndPointBuilder(string baseUrl)
        {
            BaseUrl = baseUrl;
        }

        public EndPointBuilder Append(string value) 
        {
            //localhost/api/v1
            sbUrl.Append (value);
            sbUrl.Append (defaultDelimeter);
            return this;
        }
        public EndPointBuilder AppendParam(string name, string value) 
        {
            //localhost/api/v1/user?[id=5]
            sbParam.AppendFormat ("{0}={1}&",name, value);
            return this;
        }
        public string Build() 
        {
            if (BaseUrl.EndsWith(defaultDelimeter))
            {
                sbUrl.Insert(0, BaseUrl);
            }
            else 
            {
                sbUrl.Insert (0, BaseUrl+defaultDelimeter);
            }
            var url = sbUrl.ToString ().TrimEnd('&');
            if (sbParam.Length > 0) 
            {
                var queryParam = sbParam.ToString().TrimEnd('&');
                url = sbUrl.ToString().TrimEnd(defaultDelimeter).TrimEnd('?');

                //localhost/api/v1/user?[id=5]

                url = $"{url}?{queryParam}";

            }
            return url.TrimEnd(defaultDelimeter);
        }
    }
}
