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

        private void addiistitem()
        {
            //listBox1.Items.Add(InsurancesList[1]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.FindString("BMW") != -1)
            {
                MessageBox.Show("Record Found");
            }
            else
            {
                MessageBox.Show("Record not Found");
            }
        }
    }
}
