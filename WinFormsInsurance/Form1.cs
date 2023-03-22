using System;

namespace WinFormsInsurance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string? fullName = "";
            DateTime dateOfBirth;
            string? personLocation = "";
            string? phoneNumber = "";
            string? email = "";
            string? personGender = "";
            string? coverage = "";
            string? emissions = "";
            string? carModel = "";
            string? carMake = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            string? fullName = textBox8.Text;
            DateTime dateOfBirth = Convert.ToDateTime(textBox2.Text);
            string? personLocation = textBox3.Text;
            string? phoneNumber = textBox4.Text;
            string? email = textBox5.Text;
            string? personGender = textBox6.Text;
            string? coverage = textBox7.Text;
            string? emissions = textBox10.Text;
            string? carModel = textBox11.Text;
            string? carMake = textBox12.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}