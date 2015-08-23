using Shop.WpfProj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Shop.WpfProj
{
    public class WebApiConnector : IWebApiConnector
    {
        public HttpClient CreateConnection()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:50393/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            return client;
        }
    }
}
