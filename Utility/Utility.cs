using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticCryptoMiner.Utility
{
  public static class Utility
  {
    public static string GetConfigOption(string nConfigName)
    { 
      if(string.IsNullOrEmpty(nConfigName))
        return null;

      string toReturn = null;

      try
      { 
        toReturn = ConfigurationManager.AppSettings[nConfigName];
      }
      catch(Exception)
      { 
        // Log
      }

      return toReturn;
    }
  }
}
