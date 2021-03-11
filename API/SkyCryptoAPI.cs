using AutomaticCryptoMiner.API.Models;
using AutomaticCryptoMiner.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticCryptoMiner.API
{
  public static class SkyCryptoAPI
  {
    private static string URLEndpoint { get; set; } 
    
    public static T SendAPICall<T>(ISkyRequest nRequest, string nEndPoint)
    { 
      HttpClient client = HTTPClientHandler.GetClient(nEndPoint);

      return default(T);
    }
  }
}
