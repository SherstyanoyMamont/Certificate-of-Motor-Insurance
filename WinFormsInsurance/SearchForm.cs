using Certificate_of_Motor_Insurance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsInsurance
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            addiistitem();
        }
        private void addiistitem() // Выводим все записи в бокс
        {
            for (int i = 0; i < Global.SystemState.Insurances.Count; i++)
            {
                listBox1.Items.Add(Global.SystemState.Insurances[i].Client.FullName + ", " + Global.SystemState.Insurances[i].CertificateNumber);
            }
        }
        private void button1_Click(object sender, EventArgs e) // По нажатию на кнопку ищем запись
        {
            foreach (var o in Global.SystemState.Insurances)
            {
                if (o.Client.FullName == Convert.ToString(textBox1.Text))
                {
                    MessageBox.Show("Full name: " + o.Client.Gender + " " + o.Client.FullName +
                        "\nMake auto: " + o.Client.Car.MakeAndModel +
                        "\nPrise: " + o.FinalPrice + " €" +
                        "\nDate: " + o.Date);
                    break;
                }
                else
                {
                    MessageBox.Show("Record not Found");
                }
            }
        }
    }
}
