using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace WorldData.Models
{
  public class Country
  {
      private static List<Country> _instances = new List<Country> {};
      private string _countryName;
      private int _countryPopulation;
      private string _countryRegion;
      private string _countryContinent;
      private string _countryCode;

      public Country(string countryName, int countryPopulation, string countryRegion, string countryContinent, string countryCode)
      {
          _countryName = countryName;
          _countryPopulation = countryPopulation;
          _countryRegion = countryRegion;
          _countryContinent = countryContinent;
          _countryCode = countryCode;
          _instances.Add(this);
      }


      public string CountryName { get => _countryName; set => _countryName = value;}
      public int CountryPopulation { get => _countryPopulation; set => _countryPopulation = value;}
      public string CountryRegion { get => _countryRegion; set => _countryRegion = value;}
      public string CountryContinent { get => _countryContinent; set => _countryContinent = value;}
      public string CountryCode { get => _countryCode; set => _countryCode = value;}

      public static void ClearAll()
      {
          _instances.Clear();
      }

      public static List<Country> GetAll()
      {
          List<Country> allCountries = new List<Country> {};
          MySqlConnection conn = DB.Connection();
          conn.Open();
          MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
          cmd.CommandText = @"SELECT Name, Population, Region, Continent, Code FROM country ORDER BY Name;";
          MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
          while(rdr.Read())
          {
              string countryName = rdr.GetString(0);
              int countryPopulation = rdr.GetInt32(1);
              string countryRegion = rdr.GetString(2);
              string countryContinent = rdr.GetString(3);
              string countryCode = rdr.GetString(4);
              Country newCountry = new Country(countryName, countryPopulation, countryRegion, countryContinent, countryCode);
              allCountries.Add(newCountry);
          }
          conn.Close();
          if (conn != null)
          {
              conn.Dispose();
          }
          return allCountries;
      }

    }
}
