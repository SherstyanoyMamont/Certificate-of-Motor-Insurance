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
            certificatePanel = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label14 = new Label();
            label15 = new Label();
            label1 = new Label();
            l_Vehicle = new Label();
            l_DocNumber = new Label();
            label11 = new Label();
            label10 = new Label();
            l_ClientName = new Label();
            l_StartDate = new Label();
            label9 = new Label();
            label3 = new Label();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            label12 = new Label();
            label2 = new Label();
            scrollContainerPanel = new Panel();
            certificatePanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            scrollContainerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BtnPrint
            // 
            BtnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnPrint.Location = new Point(142, 8);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(112, 34);
            BtnPrint.TabIndex = 0;
            BtnPrint.Text = "Print";
            BtnPrint.UseVisualStyleBackColor = true;
            BtnPrint.Click += BtnPrint_Click;
            // 
            // certificatePanel
            // 
            certificatePanel.BackColor = Color.White;
            certificatePanel.Controls.Add(panel3);
            certificatePanel.Controls.Add(panel2);
            certificatePanel.Location = new Point(8, 18);
            certificatePanel.Name = "certificatePanel";
            certificatePanel.Padding = new Padding(5, 25, 5, 5);
            certificatePanel.Size = new Size(850, 1100);
            certificatePanel.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(l_Vehicle);
            panel3.Controls.Add(l_DocNumber);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(l_ClientName);
            panel3.Controls.Add(l_StartDate);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(20, 148);
            panel3.Name = "panel3";
            panel3.Size = new Size(805, 924);
            panel3.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Underwriter;
            pictureBox1.Location = new Point(398, 708);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 50);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 22);
            label4.Name = "label4";
            label4.Size = new Size(198, 25);
            label4.TabIndex = 15;
            label4.Text = "1.   Document Number\t:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 49);
            label14.Name = "label14";
            label14.Size = new Size(221, 25);
            label14.TabIndex = 15;
            label14.Text = "2.   Description of Vehicle \t:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(16, 77);
            label15.Name = "label15";
            label15.Size = new Size(220, 25);
            label15.TabIndex = 15;
            label15.Text = "3.   Name of Policyholder :";
            // 
            // label1
            // 
            label1.Location = new Point(16, 104);
            label1.Name = "label1";
            label1.Size = new Size(296, 26);
            label1.TabIndex = 15;
            label1.Text = "4.   Effective Date of the Commencement of Insurance \r\n      for the purpose of the Acts ";
            // 
            // l_Vehicle
            // 
            l_Vehicle.AutoSize = true;
            l_Vehicle.ForeColor = SystemColors.ControlText;
            l_Vehicle.Location = new Point(357, 49);
            l_Vehicle.Name = "l_Vehicle";
            l_Vehicle.Size = new Size(90, 25);
            l_Vehicle.TabIndex = 1;
            l_Vehicle.Text = "<Vehicle>";
            // 
            // l_DocNumber
            // 
            l_DocNumber.AutoSize = true;
            l_DocNumber.ForeColor = SystemColors.ControlText;
            l_DocNumber.Location = new Point(357, 22);
            l_DocNumber.Name = "l_DocNumber";
            l_DocNumber.Size = new Size(144, 25);
            l_DocNumber.TabIndex = 1;
            l_DocNumber.Text = "<DOC Number>";
            // 
            // label11
            // 
            label11.Location = new Point(2, 816);
            label11.Name = "label11";
            label11.Size = new Size(798, 95);
            label11.TabIndex = 21;
            label11.Text = resources.GetString("label11.Text");
            // 
            // label10
            // 
            label10.Location = new Point(398, 768);
            label10.Name = "label10";
            label10.Size = new Size(111, 20);
            label10.TabIndex = 21;
            label10.Text = " Underwriter";
            // 
            // l_ClientName
            // 
            l_ClientName.AutoSize = true;
            l_ClientName.ForeColor = SystemColors.ControlText;
            l_ClientName.Location = new Point(357, 77);
            l_ClientName.Name = "l_ClientName";
            l_ClientName.Size = new Size(127, 25);
            l_ClientName.TabIndex = 1;
            l_ClientName.Text = "<ClientName>";
            // 
            // l_StartDate
            // 
            l_StartDate.AutoSize = true;
            l_StartDate.ForeColor = SystemColors.ControlText;
            l_StartDate.Location = new Point(357, 104);
            l_StartDate.Name = "l_StartDate";
            l_StartDate.Size = new Size(109, 25);
            l_StartDate.TabIndex = 1;
            l_StartDate.Text = "<StartDate>";
            // 
            // label9
            // 
            label9.Location = new Point(16, 668);
            label9.Name = "label9";
            label9.Size = new Size(296, 90);
            label9.TabIndex = 21;
            label9.Text = "      Munster Motor Insurance\r\n      Thomond Parc House\r\n      Limerick";
            // 
            // label3
            // 
            label3.Location = new Point(16, 130);
            label3.Name = "label3";
            label3.Size = new Size(276, 60);
            label3.TabIndex = 16;
            label3.Text = "5.   Date of expiry of Insurance \r\n         MIDNIGHT: ";
            // 
            // label8
            // 
            label8.Location = new Point(16, 544);
            label8.Name = "label8";
            label8.Size = new Size(771, 110);
            label8.TabIndex = 20;
            label8.Text = resources.GetString("label8.Text");
            // 
            // label5
            // 
            label5.Location = new Point(16, 190);
            label5.Name = "label5";
            label5.Size = new Size(771, 108);
            label5.TabIndex = 18;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label7
            // 
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(16, 415);
            label7.Name = "label7";
            label7.Size = new Size(615, 134);
            label7.TabIndex = 19;
            label7.Text = resources.GetString("label7.Text");
            // 
            // label6
            // 
            label6.Location = new Point(16, 329);
            label6.Name = "label6";
            label6.Size = new Size(771, 81);
            label6.TabIndex = 18;
            label6.Text = "7.   Limitations to use as defined below \r\n      Use only for Private Hire meaning the conveyance of passengers for hire or reward\r\n      Use for social, Domestic, and Pleasure purposes only ";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Logo;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(20, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(805, 131);
            panel2.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(622, 44);
            label12.Margin = new Padding(0);
            label12.Name = "label12";
            label12.Size = new Size(120, 38);
            label12.TabIndex = 1;
            label12.Text = "Munster";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 36);
            label2.Name = "label2";
            label2.Size = new Size(407, 45);
            label2.TabIndex = 14;
            label2.Text = "Certificate Motor Insurance";
            // 
            // scrollContainerPanel
            // 
            scrollContainerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            scrollContainerPanel.AutoScroll = true;
            scrollContainerPanel.BackColor = Color.FromArgb(64, 64, 64);
            scrollContainerPanel.Controls.Add(certificatePanel);
            scrollContainerPanel.Location = new Point(14, 48);
            scrollContainerPanel.Name = "scrollContainerPanel";
            scrollContainerPanel.Padding = new Padding(5, 15, 5, 25);
            scrollContainerPanel.Size = new Size(1018, 898);
            scrollContainerPanel.TabIndex = 1;
            // 
            // Report
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1044, 958);
            Controls.Add(scrollContainerPanel);
            Controls.Add(BtnPrint);
            ForeColor = SystemColors.ControlText;
            MinimizeBox = false;
            MinimumSize = new Size(480, 240);
            Name = "Report";
            Text = "Report";
            Shown += Report_Shown;
            certificatePanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            scrollContainerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button BtnPrint;
        private Panel certificatePanel;
        private Label l_DocNumber;
        private Label label10;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label1;
        private Panel scrollContainerPanel;
        private Label l_Vehicle;
        private Label l_StartDate;
        private Label l_ClientName;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label12;
        private Label label4;
        private Label label14;
        private Label label15;
    }
}