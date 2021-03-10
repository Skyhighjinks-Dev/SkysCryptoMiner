using AutomaticCryptoMiner.Aspects;
using AutomaticCryptoMiner.Configuration;
using AutomaticCryptoMiner.Miner;
using System;

namespace AutomaticCryptoMiner
{
  class Program
  {
    [StartUp]
    static void Main(string[] args)
    {
      Controller.Initialize();
    }
  }
}
