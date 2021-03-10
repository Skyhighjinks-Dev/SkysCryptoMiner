using AutomaticCryptoMiner.Interfaces;
using AutomaticCryptoMiner.Miner;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticCryptoMiner.Aspects
{
  [Serializable]
  public class StartUp : OnMethodBoundaryAspect
  {
    public override void RuntimeInitialize(MethodBase method)
    {
      List<ISkyStaticInterface> toInitalize = new List<ISkyStaticInterface>
      {
        new LoggerAspect(),
        new WalletAspect()
      };

      toInitalize.ForEach(x => x.Initalize());
      Controller.Initialize();
    }
  }
}
