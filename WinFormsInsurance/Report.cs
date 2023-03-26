using Certificate_of_Motor_Insurance;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;

using Newtonsoft.Json;

namespace WinFormsInsurance
{

    //2480 x 3508  // A4
    //1240 x 1754  // half A4
    public partial class Report : Form
    {
        // здесь нужен какой то класс который хранит всю информацию которую ты подгружаешь на конечный документ
        // сделай это свойство public что бы его можно было присвоить из главной формы
        //  public ListInsurance listInsurance;

        public Report()
        {
            InitializeComponent();
        }

        // это событие возникает когда форма отображается впервые

        private void Report_Shown(object sender, EventArgs e)
        {
            // здесь присвой значения всем label-ам  из класса с данными которые ты передаешь в эту форму

            l_DocNumber.Text = "FCCC2209202300"; //listInsurance.Insurance.CertificateNumber.ToString();
            l_Vehicle.Text = "Opel Corsa";
            l_StartDate.Text = DateTime.Now.ToString();
            l_ClientName.Text = "John Doe";
            //etc...
        }

        public Bitmap PanelToBitmap(Panel RootPanel)
        {
            var sz = RootPanel.Size;

            Bitmap panelImage = new Bitmap(sz.Width, sz.Height);
            RootPanel.DrawToBitmap(panelImage, new Rectangle(0, 0, sz.Width, sz.Height));

            return panelImage;

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

            // рисуем все что находится на панели sertificatePanel в изображение pageImage
            Bitmap pageImage = PanelToBitmap(certificatePanel);
            pageImage.Save("test.jpg"); //просто для проверки того как изображение с панели отрендерилось (оно выходит качественней чем pdf)

            // размер бумаги ставим что бы соотвествовал размеру панели
            // конечно размер панели желательно что бы был пропорционален А4
            PrintDocument pd = new PrintDocument();
            var pgs = pd.DefaultPageSettings;
            pgs.PaperSize = new PaperSize("Custom Size", certificatePanel.Width, certificatePanel.Height);
            pd.DefaultPageSettings = pgs;

            pd.PrintPage += delegate (object o, PrintPageEventArgs e)
            {
                // SourceCopy вроде дает более точный результат, но появляются артефакты вокруг текста от компрессии изображения
                e.Graphics.CompositingMode = CompositingMode.SourceOver;
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
                e.Graphics.DrawImage(pageImage, 0, 0, e.PageBounds.Width, e.PageBounds.Height);
            };

            pd.Print();

        }


        /////// JSON пример

        //public void JSONSaveLoad()
        //{


        //    string? fileName = "instance.json";
        //    string? jsonString = JsonConvert.SerializeObject(Insurance.ListInsurance);

        //    JSONSaveLoad instance = new JSONSaveLoad(fileName, jsonString);

        //    // cохранить в файл
        //    File.WriteAllText(fileName, jsonString);
        //    //File.WriteAllText(fileName, JsonConvert.SerializeObject(instance, Formatting.Indented)); - starting version
        //    // загрузить обратно
        //    instance = JsonConvert.DeserializeObject<JSONSaveLoad>(fileName);
        //}



    }
}







