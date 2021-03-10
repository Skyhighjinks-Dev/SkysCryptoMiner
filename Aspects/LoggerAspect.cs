using AutomaticCryptoMiner.Interfaces;
using Serilog;
using System;
using System.IO;

namespace AutomaticCryptoMiner.Aspects
{
  public class LoggerAspect : ISkyStaticInterface
  {
    public void Initalize()
    {
      DateTime currDate = DateTime.Now;
      string dateFormat = currDate.ToString("d").Replace("//".ToCharArray()[0], '-');

      string logPath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..", "Logs", $"{dateFormat}.txt"));

      Log.Logger = new LoggerConfiguration()
        .MinimumLevel.Debug()
        .WriteTo.File(logPath)
        .CreateLogger();

      Log.Debug("Application has started\n\n");
    }
  }
}
