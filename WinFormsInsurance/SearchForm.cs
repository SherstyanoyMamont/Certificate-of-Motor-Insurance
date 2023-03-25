using Certificate_of_Motor_Insurance;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Office2013.Word;
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
            for (int i = 0; i < Insurance.ListInsurance.Count; i++)
            {
                listBox1.Items.Add(Insurance.ListInsurance[i].Client.FullName + ", " + Insurance.ListInsurance[i].CertificateNumber);
            }
        }
        private void button1_Click(object sender, EventArgs e) // По нажатию на кнопку ищем запись
        {
            foreach (var o in Insurance.ListInsurance)
            {
                if (o.Client.FullName == Convert.ToString(textBox1.Text))
                {
                    MessageBox.Show("Full name: " + o.Client.Gender + " " + o.Client.FullName +
                        "\nMake auto: " + o.Client.Car.MakeAndModel +
                        "\nPrise: " + o.FinalPrice +
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
