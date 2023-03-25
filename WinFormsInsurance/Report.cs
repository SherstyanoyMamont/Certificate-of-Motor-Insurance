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
    public partial class Report : Form
    {
        Bitmap pageImage;
        public ListInsurance listInsurance;

        public Report()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        // Присваиваем значения кнопкам
        private void Report_Shown(object sender, EventArgs e)
        {
            lDocNumber.Text = "SN338599324"; //listInsurance.Insurance.CertificateNumber.ToString();
        }

        // Создаем документ ПДФ по форме
        private void BtnPrint_Click_1(object sender, EventArgs e)  // По нажатию на кнопку создаем обкартинку...
        {
            pageImage = new Bitmap(richTextBox1.Size.Width, richTextBox1.Size.Height);
            richTextBox1.DrawToBitmap(pageImage, richTextBox1.ClientRectangle);
            printDocument1.Print();
        }

        // Печатаем картинку в пдф
        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pageImage, 0, 0);
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        // Вывод документа ПДФ в папку с файлом
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            string fn = "CertificatePDF.pdf";
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = fn;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }
    }
}







