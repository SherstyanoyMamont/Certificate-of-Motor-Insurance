﻿using Certificate_of_Motor_Insurance;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace WinFormsInsurance
{

    public static class Global
    {
        public static SystemState SystemState = null;
    }

    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

            string? fullName = nameBox.Text;
            DateTime dateOfBirth = dateOfBirthBox.Value;
            DateTime dateTime = dateBox.Value;
            string? clientLocation = countyBox.Text;
            string? phoneNumber = phoneBox.Text;
            string? email = emailBox.Text;
            string? clientGender = genBox.Text;
            string? coverage = coverageBox.Text;
            string? emissions = emissionBox.Text;
            string? carMakeAndModel = modelBox.Text;

            Car car = new Car(carMakeAndModel, emissions);
            Client client = new Client(clientGender, fullName, dateOfBirth, clientLocation, car, email, phoneNumber);
            if (!Global.SystemState.Clients.Contains(client))
            {
                Global.SystemState.Clients.Add(client);
            }

            Insurance insurance = new Insurance(client, coverage, dateTime);
            if (!Global.SystemState.Insurances.Contains(insurance))
            {
                Global.SystemState.Insurances.Add(insurance);
            }

            JSONManager.Save("SystemState.json", Global.SystemState);

            Report report = new Report();
            report.insurance = insurance;
            report.Show();
        }

        private void SerchBut_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm();
            
            search.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Global.SystemState = JSONManager.Load("SystemState.json");
            if (Global.SystemState == null)
            {
                Global.SystemState = new SystemState();
            }
        }
    }
}