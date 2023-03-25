using Certificate_of_Motor_Insurance;
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
            // Присваиваем переменным значение полей на форме
            string? fullName = nameBox.Text;
            DateTime dateOfBirth = Convert.ToDateTime("18/12/1998");//dateOfBirthBox;
            string? personLocation = countyBox.Text;
            string? phoneNumber = phoneBox.Text;
            string? email = emailBox.Text;
            string? personGender = genBox.Text;
            string? coverage = coverageBox.Text;
            string? emissions = emissionBox.Text;
            string? carMakeAndModel = modelBox.Text;

            Car car = new Car(carMakeAndModel, emissions);
            Person client = new Person(personGender, fullName, dateOfBirth, personLocation, car, email, phoneNumber);
            Insurance inshurance1 = new Insurance(client, coverage);
            ListInsurance List = new ListInsurance(inshurance1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            //report.listInsurance
            report.Show();
        }
    }
}