using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace WorldData.Models
{

    public class City
    {
        private string _cityName;
        private int _cityPopulation;
        private string _cityCode;

        public City (string cityName, int cityPopulation, string cityCode)
        {
          _cityName = cityName;
          _cityPopulation = cityPopulation;
          _cityCode = cityCode;
        }

        public string GetCityName()
        {
            return _cityName;
        }

        public void SetCityName(string newCityName)
        {
            _cityName = newCityName;
        }

        public int GetCityPopulation()
        {
            return _cityPopulation;
        }

        public void SetCityPopulation(int newCityPopulation)
        {
            _cityPopulation = newCityPopulation;
        }

        public string GetCityCode()
        {
            return _cityCode;
        }

        public void SetCityCode(string newCityCode)
        {
            _cityName = newCityCode;
        }

        public static List<City> GetAll(string countryName)
        {
            List<City> allCities = new List<City> {};
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT Name, Population, CountryCode FROM city WHERE CountryCode ='" + countryName + "' ORDER BY Name;";
            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            while(rdr.Read())
            {
                string cityName = rdr.GetString(0);
                int cityPopulation = rdr.GetInt32(1);
                string cityCode = rdr.GetString(2);
                City newCity = new City(cityName, cityPopulation, cityCode);
                allCities.Add(newCity);

            }
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return allCities;
        }

    }
}
