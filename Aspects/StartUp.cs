using AutomaticCryptoMiner.Interfaces;
using AutomaticCryptoMiner.Miner;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace AutomaticCryptoMiner.Aspects
{
  [Serializable]
  public class StartUp : OnMethodBoundaryAspect
  {
    public override void RuntimeInitialize(MethodBase method)
    {
      List<ISkyAspect> toInitalize = new List<ISkyAspect>
      {
        new LoggerAspect(),
        new WalletAspect(),
        new PoolAspect()
      };

      toInitalize.ForEach(x => x.Initalize());
      Controller.Initialize();
    }
  }
}
