﻿using DesktopSchedulingApp.Models;
using DesktopSchedulingApp.Repository;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DesktopSchedulingApp.Service
{
    internal static class AddressService
    {
        public static List<Address> Addresses;
        private static List<Address> DBAddresses;
        private static int highestID = 0;

        private static void ReadAddressData()
        {
            Addresses = [];
            DBAddresses = [];
            string sql = "SELECT * FROM Address";
            MySqlCommand cmd = new MySqlCommand(sql, DBConnection.conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Address address = new
                    (
                        rdr.GetInt32("addressId"),
                        rdr.GetString("address"),
                        rdr.GetString("phone"),
                        rdr.GetInt32("cityId")
                    );
                DBAddresses.Add(address);
                Addresses.Add(address);
                if (address.AddressId > highestID)
                {
                    highestID = address.AddressId;
                }
            }
            rdr.Close();
        }

        public static void ViewAddresses()
        {
            ReadAddressData();
        }

        public static bool AddressExistsById(int id)
        {
            foreach (Address address in DBAddresses)
            {
                if (address.AddressId == id)
                {
                    return true;
                }
            }
            GetNewAddressID();
            return false;
        }

        private static bool AddressExists(Address address)
        {
            Boolean exists = false;
            foreach (Address a in Addresses)
            {
                if (a.AddressId != address.AddressId)
                {
                    if (a.StreetAddress == address.StreetAddress
                        && a.Phone == address.Phone
                        && a.CityId == address.CityId
                        && AddressExistsById(address.AddressId))
                    {
                        exists = true;
                    }
                }
            }
            return exists;
        }

        public static Address FindByStreetName(string streetName)
        {
            foreach (Address address in Addresses)
            {
                if (address.StreetAddress.Equals(streetName))
                {
                    return address;
                }
            }
            return null;
        }

        public static int GetAddressID(string streetName)
        {
            if (FindByStreetName(streetName) != null)
            {
                return FindByStreetName(streetName).AddressId;
            }
            return GetNewAddressID();
        }

        private static int GetNewAddressID()
        {
            return highestID += 1;
        }

        public static void AddAddress(Address address)
        {
            if (!AddressExists(address))
            {
                Addresses.Add(address);
            }
        }
    }
}
