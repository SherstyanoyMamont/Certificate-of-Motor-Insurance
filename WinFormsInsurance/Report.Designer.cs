namespace WinFormsInsurance
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            BtnPrint = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox2 = new PictureBox();
            lDocNumber = new Label();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnPrint
            // 
            BtnPrint.Location = new Point(3, 1284);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(112, 34);
            BtnPrint.TabIndex = 0;
            BtnPrint.Text = "Print";
            BtnPrint.UseVisualStyleBackColor = true;
            BtnPrint.Click += BtnPrint_Click_1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1188, 1268);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.AccessibleRole = AccessibleRole.None;
            tabPage1.AutoScroll = true;
            tabPage1.BackColor = SystemColors.ControlLightLight;
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(lDocNumber);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1180, 1230);
            tabPage1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Underwriter1;
            pictureBox2.Location = new Point(469, 999);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(211, 55);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // lDocNumber
            // 
            lDocNumber.AutoSize = true;
            lDocNumber.Location = new Point(360, 206);
            lDocNumber.Name = "lDocNumber";
            lDocNumber.Size = new Size(144, 25);
            lDocNumber.TabIndex = 1;
            lDocNumber.Text = "<DOC Number>";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo1;
            pictureBox1.Location = new Point(369, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(747, 123);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 32);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1165, 1181);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(BtnPrint, 0, 1);
            tableLayoutPanel1.Controls.Add(tabControl1, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100.000008F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1194, 1321);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage_1;
            // 
            // Report
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(1218, 1352);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MinimizeBox = false;
            Name = "Report";
            Text = "Report";
            Shown += Report_Shown;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button BtnPrint;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label lDocNumber;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private RichTextBox richTextBox1;
    }
}