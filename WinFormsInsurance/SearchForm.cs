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

        // Output all quotation in the list box
        private void addiistitem()
        {
            for (int i = 0; i < Global.SystemState.Insurances.Count; i++)
            {
                listBox1.Items.Add(Global.SystemState.Insurances[i].Client.FullName + ", " + Global.SystemState.Insurances[i].CertificateNumber);
            }
        }

        // Search quotation when click the button
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var o in Global.SystemState.Insurances)
            {
                if (o.Client.FullName == Convert.ToString(textBox1.Text) || o.CertificateNumber == Convert.ToString(textBox1.Text) || o.Client.FullName + ", " + o.CertificateNumber == Convert.ToString(textBox1.Text))
                {
                    MessageBox.Show("Full name: " + o.Client.Gender + ". " + o.Client.FullName +
                        "\nE-mail: " + o.Client.Email +
                        "\nPhone number: " + o.Client.PhoneNumber +
                        "\nLocation: " + o.Client.Location +
                        "\nAge: " + o.Client.Age +
                        "\nMake auto: " + o.Client.Car.MakeAndModel +
                        "\nPrise of insurance: " + o.FinalPrice + " €" +
                        "\nDate: " + o.Date);
                    break;
                }
            }
        }

        // Copy text from listBox to search bar on double click
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.DoubleClick += new EventHandler(ListBox1_DoubleClick);
        }
        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
            }
        }
    }
}
