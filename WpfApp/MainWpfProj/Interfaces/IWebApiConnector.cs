using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Shop.WpfProj.Interfaces
{
    public interface IWebApiConnector
    {
        HttpClient CreateConnection();
    }
}
