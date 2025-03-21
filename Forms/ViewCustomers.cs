﻿using DesktopSchedulingApp.Models;
using DesktopSchedulingApp.Repository;
using DesktopSchedulingApp.Service;
using System;
using System.Windows.Forms;

namespace DesktopSchedulingApp.Forms
{
    public partial class ViewCustomers : Form
    {
        Customer selectedCustomer;
        Address selectedAddress;
        City selectedCity;
        Country selectedCountry;

        public ViewCustomers()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            PopulateCustomerTable();
        }

        private void PopulateCustomerTable()
        {
            DBCommands.LoadCustomerData(this);
            AddressService.ViewAddresses();
            CityService.ViewCities();
            CountryService.ViewCountries();
            dataGridView1.CurrentCell = null;
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            new AddCustomer().ShowDialog();
            PopulateCustomerTable();
        }

        private void ModifyCustomerBtn_Click(object sender, EventArgs e)
        {
            new ModifyCustomer(selectedCustomer, selectedAddress, selectedCity, selectedCountry).ShowDialog();
            PopulateCustomerTable();
        }

        private void DeleteCustomerBtn_Click(object sender, EventArgs e)
        {
            CustomerService.DeleteCustomer(selectedCustomer);
            PopulateCustomerTable();
        }

        private void CustomerSelection(object sender, EventArgs e)
        {
            selectedCustomer = CustomerService.FindByCustomerId(Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value));
            selectedAddress = AddressService.FindByAddressId(Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value));
            selectedCity = CityService.FindByCityId(Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value));
            selectedCountry = CountryService.FindByCountryId(Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value));
        }
    }
}
