﻿using DesktopSchedulingApp.Models;
using DesktopSchedulingApp.Repository;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DesktopSchedulingApp.Service
{
    internal static class CountryService
    {
        public static List<Country> Countries;
        private static int highestID = 0;

        private static void ReadCountryData()
        {
            Countries = [];
            string sql = "SELECT * FROM country";
            MySqlCommand cmd = new(sql, DBConnection.conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Country country = new
                    (
                        rdr.GetInt32("countryId"),
                        rdr.GetString("country")
                    );
                Countries.Add(country);
                if (country.CountryId > highestID)
                {
                    highestID = country.CountryId;
                }
            }
            rdr.Close();
        }

        public static void ViewCountries()
        {
            ReadCountryData();
        }

        public static bool IsDuplicate(Country country)
        {
            foreach (Country c in Countries)
            {
                if (c.CountryId == country.CountryId)
                {
                    return true;
                }
            }
            return false;
        }

        public static Country FindByCountryName(string countryName)
        {
            foreach (Country country in Countries)
            {
                if (country.CountryName.Equals(countryName))
                {
                    return country;
                }
            }
            return null;
        }

        public static Country FindByCountryId(int countryId)
        {
            foreach (Country country in Countries)
            {
                if (country.CountryId == countryId)
                {
                    return country;
                }
            }
            return null;
        }

        public static int GetCountryID(string countryName)
        {
            if (FindByCountryName(countryName) != null)
            {
                return FindByCountryName(countryName).CountryId;
            }
            return highestID += 1;
        }
    }
}
