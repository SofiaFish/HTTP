using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace HttpRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            string endPoint = "https://google.com";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(endPoint);
            request.Method = "GET";
            request.UserAgent = "browser";
            request.Headers.Add("Content-Type", "application/json");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            Console.WriteLine(reader.ReadToEnd());
            response.Close();
            reader.Close();

        }
    }
}
