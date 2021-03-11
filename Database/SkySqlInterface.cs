using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticCryptoMiner.Database
{
  public static class SkySqlInterface
  {
    private static SqlConnection Conn { get; set;}

    public static void Initialize()
    { 
      Conn = new SqlConnection(GetConnectionString());
    }

    public static SqlConnection GetSqlConnection()
    { 
      // Ensure it's closed and reopens it.
      if(Conn.State == System.Data.ConnectionState.Open)
        Conn.Close();

      Conn.Open();

      return Conn;
    }


    private static string GetConnectionString()
    { 
      return ConfigurationManager.ConnectionStrings["DBConnStr"].ConnectionString;
    }
  }
}
