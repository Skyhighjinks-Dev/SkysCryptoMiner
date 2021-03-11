
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticCryptoMiner.API.Models
{
  public static class HTTPClientHandler
  {
    private static Dictionary<string, HttpClient> HttpClientList { get; set; }

    public static HttpClient GetClient(string nEndPoint)
    { 
      string key = null;

      if(!(!HttpClientList?.ContainsKey(nEndPoint.ToLower()) ?? false))
      { 
        if(HttpClientList == null)
          HttpClientList = new Dictionary<string, HttpClient>(); 

        HttpClientList.Add(nEndPoint.ToLower(), new HttpClient());
      }

      return HttpClientList[nEndPoint.ToLower()];
    }
  }
}
