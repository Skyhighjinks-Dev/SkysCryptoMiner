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
  public class WalletAspect : ISkyAspect
  {
    public void Initalize()
    {
      WalletAddress.Ada = GetConfigOption(WalletName("Ada"));
      WalletAddress.Btc = GetConfigOption(WalletName("Btc"));
      WalletAddress.Chain = GetConfigOption(WalletName("Chain"));
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

  public class PoolAspect : ISkyAspect
  {
    public void Initalize()
    {
      MiningPool.Ada = GetConfigOption(PoolName("Ada"));
      MiningPool.Btc = GetConfigOption(PoolName("Btc"));
      MiningPool.Chain = GetConfigOption(PoolName("Chain"));
      MiningPool.Dot = GetConfigOption(PoolName("Dot"));
      MiningPool.Eth = GetConfigOption(PoolName("Eth"));
      MiningPool.Ltc = GetConfigOption(PoolName("Ltc"));
      MiningPool.Rvn = GetConfigOption(PoolName("Rvn"));
      MiningPool.Usdt = GetConfigOption(PoolName("Usdt"));
      MiningPool.Xml = GetConfigOption(PoolName("Xml"));
      MiningPool.Xmr = GetConfigOption(PoolName("Xmr"));
    }

    private static string PoolName(string nPool)
    { 
      if(string.IsNullOrEmpty(nPool)) return null;

      return $"{nPool}PoolAddress";
    }
  }
}
