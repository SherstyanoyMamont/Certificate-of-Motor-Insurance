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
            string? fullName = textBox8.Text;
            DateTime dateOfBirth = Convert.ToDateTime(dateTimePicker1);
            string? personLocation = textBox3.Text;
            string? phoneNumber = textBox4.Text;
            string? email = textBox5.Text;
            string? personGender = textBox6.Text;
            string? coverage = textBox7.Text;
            string? emissions = textBox10.Text;
            string? carModel = textBox10.Text;  // Необходимо изменить посторение
            string? carMake = textBox12.Text;

            // Использование для Word Helper - который исключен из проекта
            //var helper = new WordHelper("Certificate of Motor Insurance - without data.docx");
            //var items = new Dictionary<string, string>
            //{
            //    {"Document Number", "Document Number  " + fullName}
            //};

            //helper.Process(items);

            // Создаем объекты
            Car car = new Car(carMake, carModel, emissions);
            Person client = new Person(personGender, fullName, dateOfBirth, personLocation, car, email, phoneNumber);
            Insurance inshurance1 = new Insurance(client, coverage);
            ListInsurance List = new ListInsurance(inshurance1);

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(e.CloseReason == CloseReason.ApplicationExitCall))
            {
                if (MessageBox.Show("Уже уходите?", "Выход", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void SerchBut_Click(object sender, EventArgs e)
        {

        }
    }
}