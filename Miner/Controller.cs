using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomaticCryptoMiner.Miner
{
  public static class Controller
  {
    public enum WalletOptions 
    { 
      Btc,
      Eth,
      Rvn,
      Ltc,
      Ada,
      Dot,
      Xml,
      Chain,
      Bnb,
      Usdt,
      Xmr
    }

    private static Thread CurrentThread;
    private static WalletOptions? CurrentOption;

    public static void Initialize()
    {
      if(CurrentThread != null)
        return;

      #pragma warning disable CS4014 
      CurrentThread = new Thread(new ThreadStart(() => ControlThread()));
      CurrentThread.Start();
      #pragma warning restore CS4014 
    }

    public static void ChangeCoin(WalletOptions nOption)
    { 
      CurrentOption = nOption;
    }

    public static Thread GetThread()
    { 
      return CurrentThread;
    }

    private async static Task<bool> UpdateThread()
    { 
      

      return await Task.FromResult(true);
    }

    private async static Task ControlThread()
    {
      while (true)
      {
        try
        {
          if (CurrentOption == null)
          {
            await UpdateThread();
          }
        }
        catch (Exception ex)
        {
          Serilog.Log.Error(ex.ToString());
        }
        finally
        {
          Thread.Sleep(60 * 1000);
        }
      }
    }

  }
}
