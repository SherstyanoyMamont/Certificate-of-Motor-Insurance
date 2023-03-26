using Certificate_of_Motor_Insurance;
using Newtonsoft.Json;
using System;

namespace WinFormsInsurance
{
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
            string? personLocation = countyBox.Text;
            string? phoneNumber = phoneBox.Text;
            string? email = emailBox.Text;
            string? personGender = genBox.Text;
            string? coverage = coverageBox.Text;
            string? emissions = emissionBox.Text;
            string? carMakeAndModel = modelBox.Text;

            // Create the objects
            Car car = new Car(carMakeAndModel, emissions);
            Person client = new Person(personGender, fullName, dateOfBirth, personLocation, car, email, phoneNumber);
            Insurance inshurance1 = new Insurance(client, coverage, dateTime);
            JSONSaveLoad instance = new JSONSaveLoad(inshurance1);

            // загрузить обратно
            //instance = JsonConvert.DeserializeObject<JSONSaveLoad>(instance.FileName);

            // Save all info in ListInsurance in .text - file
            File.WriteAllText(instance.FileName, instance.JsonString);


            Report report = new Report();
            report.Show();
        }

        private void SerchBut_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm();
            //report.listInsurance
            search.Show();
        }
    }
}