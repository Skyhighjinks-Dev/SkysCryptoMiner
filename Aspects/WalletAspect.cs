using AutomaticCryptoMiner.Configuration;
using AutomaticCryptoMiner.Interfaces;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using static AutomaticCryptoMiner.Utility.Utility;

namespace AutomaticCryptoMiner.Aspects
{
  public class WalletAspect : ISkyStaticInterface
  {
    public void Initalize()
    {
      WalletAddress.Ada = GetConfigOption(WalletName("Ada"));
      WalletAddress.Btc = GetConfigOption(WalletName("Btc"));
      WalletAddress.Chain = GetConfigOption("ChainlinkAddr");
      WalletAddress.Dot = GetConfigOption(WalletName("Dot"));
      WalletAddress.Eth = GetConfigOption(WalletName("Eth"));
      WalletAddress.Ltc = GetConfigOption(WalletName("Ltc"));
      WalletAddress.Rvn = GetConfigOption(WalletName("Rvn"));
      WalletAddress.Usdt = GetConfigOption(WalletName("Usdt"));
      WalletAddress.Xml = GetConfigOption(WalletName("Xml"));
      WalletAddress.Xmr = GetConfigOption(WalletName("Xmr"));
    }

    private static string WalletName(string nCoin)
    { 
      if(string.IsNullOrEmpty(nCoin)) return null;

      return $"{nCoin}WalletAddr";
    }
  }
}
