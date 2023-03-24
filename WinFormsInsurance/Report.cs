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
    public partial class Report : Form
    {
        Bitmap pageImage;

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)   // Print to PDF
        {
            //pageImage = new Bitmap(pagePanel.Size.Width, pagePanel.Size.Height);
            //pagePanel.DrawToBitmap(pageImage, pagePanel.ClientRectangle);
            //printDocument1.Print();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pageImage, 0, 0);
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                if (MessageBox.Show("Уже уходите?", "Выход", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pagePanel_Paint(object sender, PaintEventArgs e)
        {
            string fn = "CertificatePDF.pdf";
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = fn;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            //OpenFileDialog1.InitialDirectory = Path.Combine(Environment.CurrentDirectory);
            //OpenFileDialog1.FileName = Path.Combine(Environment.CurrentDirectory, "CertificatePDF.pdf");
        }

        //if (OpenFileDialogFileDialog1.ShowDialog() == DialogResult.OK)
        //{
        //    switch (TabControl1.SelectedIndex)
        //    {
               
        //    }
        //}
    }
}







