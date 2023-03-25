namespace WinFormsInsurance
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            emailBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label10 = new Label();
            label12 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            dateBox = new DateTimePicker();
            label9 = new Label();
            SerchBut = new Button();
            countyBox = new ComboBox();
            personBindingSource = new BindingSource(components);
            genBox = new ComboBox();
            emissionBox = new ComboBox();
            coverageBox = new ComboBox();
            modelBox = new ComboBox();
            phoneBox = new MaskedTextBox();
            nameBox = new TextBox();
            dateOfBirthBox = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1045, 613);
            button1.Name = "button1";
            button1.Size = new Size(163, 55);
            button1.TabIndex = 0;
            button1.Text = "Done";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseClick += button1_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 128);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 2;
            label1.Text = "Name of Policyholder";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 216);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 3;
            label2.Text = "Date of birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 303);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 5;
            label3.Text = "County";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 390);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 7;
            label4.Text = "Phone Number";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(61, 520);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(384, 31);
            emailBox.TabIndex = 12;
            emailBox.Text = "iikorotkov@gmai.com";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 574);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 11;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 486);
            label6.Name = "label6";
            label6.Size = new Size(61, 25);
            label6.TabIndex = 9;
            label6.Text = "E-mail";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(603, 221);
            label10.Name = "label10";
            label10.Size = new Size(82, 25);
            label10.TabIndex = 17;
            label10.Text = "Emission";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(603, 140);
            label12.Name = "label12";
            label12.Size = new Size(188, 25);
            label12.TabIndex = 14;
            label12.Text = "Description of Vehicle ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(603, 301);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 19;
            label7.Text = "Coverage";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(438, 28);
            label8.Name = "label8";
            label8.Size = new Size(295, 54);
            label8.TabIndex = 21;
            label8.Text = "Insurance Form";
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1188, 12);
            button2.Name = "button2";
            button2.Size = new Size(58, 34);
            button2.TabIndex = 24;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            // 
            // dateBox
            // 
            dateBox.Format = DateTimePickerFormat.Short;
            dateBox.Location = new Point(603, 603);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(384, 31);
            dateBox.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(603, 567);
            label9.Name = "label9";
            label9.Size = new Size(49, 25);
            label9.TabIndex = 27;
            label9.Text = "Date";
            // 
            // SerchBut
            // 
            SerchBut.Location = new Point(1045, 520);
            SerchBut.Name = "SerchBut";
            SerchBut.Size = new Size(163, 50);
            SerchBut.TabIndex = 28;
            SerchBut.Text = "Search";
            SerchBut.UseVisualStyleBackColor = true;
            SerchBut.Click += SerchBut_Click;
            // 
            // countyBox
            // 
            countyBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countyBox.FormattingEnabled = true;
            countyBox.Items.AddRange(new object[] { "Clare", "Limerick", "Tipperary", "Waterford", "Cork" });
            countyBox.Location = new Point(61, 335);
            countyBox.Name = "countyBox";
            countyBox.Size = new Size(384, 33);
            countyBox.TabIndex = 29;
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(Certificate_of_Motor_Insurance.Person);
            // 
            // genBox
            // 
            genBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genBox.FormattingEnabled = true;
            genBox.Items.AddRange(new object[] { "Mr", "Ms" });
            genBox.Location = new Point(61, 613);
            genBox.Name = "genBox";
            genBox.Size = new Size(384, 33);
            genBox.TabIndex = 30;
            // 
            // emissionBox
            // 
            emissionBox.DropDownStyle = ComboBoxStyle.DropDownList;
            emissionBox.FormattingEnabled = true;
            emissionBox.Items.AddRange(new object[] { "High", "Medium", "Low" });
            emissionBox.Location = new Point(603, 257);
            emissionBox.Name = "emissionBox";
            emissionBox.Size = new Size(384, 33);
            emissionBox.TabIndex = 31;
            // 
            // coverageBox
            // 
            coverageBox.DropDownStyle = ComboBoxStyle.DropDownList;
            coverageBox.FormattingEnabled = true;
            coverageBox.Items.AddRange(new object[] { "Fully Comprehensive", "Third Party Fire and Theft" });
            coverageBox.Location = new Point(603, 336);
            coverageBox.Name = "coverageBox";
            coverageBox.Size = new Size(384, 33);
            coverageBox.TabIndex = 32;
            // 
            // modelBox
            // 
            modelBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modelBox.FormattingEnabled = true;
            modelBox.Items.AddRange(new object[] { "BMW Gran Turismo", "BMW X6", "BMW Z4", "Opel Corsa", "Opel Astra", "Opel Vectra", "Toyota Yaris", "Toyota Auris", "Toyota Corolla", "Toyota Avensis", "Renault Fleunce", "Renault Megane", "Renault Clio" });
            modelBox.Location = new Point(603, 181);
            modelBox.Name = "modelBox";
            modelBox.Size = new Size(384, 33);
            modelBox.TabIndex = 33;
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(61, 431);
            phoneBox.Mask = "(999) 000-0000";
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(384, 31);
            phoneBox.TabIndex = 34;
            phoneBox.Text = "0852848110";
            // 
            // nameBox
            // 
            nameBox.AccessibleName = "";
            nameBox.Location = new Point(61, 166);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(384, 31);
            nameBox.TabIndex = 35;
            nameBox.Text = "Ivan Korotkov";
            // 
            // dateOfBirthBox
            // 
            dateOfBirthBox.Format = DateTimePickerFormat.Short;
            dateOfBirthBox.Location = new Point(61, 255);
            dateOfBirthBox.Name = "dateOfBirthBox";
            dateOfBirthBox.Size = new Size(384, 31);
            dateOfBirthBox.TabIndex = 36;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 696);
            Controls.Add(dateOfBirthBox);
            Controls.Add(nameBox);
            Controls.Add(phoneBox);
            Controls.Add(modelBox);
            Controls.Add(coverageBox);
            Controls.Add(emissionBox);
            Controls.Add(genBox);
            Controls.Add(countyBox);
            Controls.Add(SerchBut);
            Controls.Add(label9);
            Controls.Add(dateBox);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label10);
            Controls.Add(label12);
            Controls.Add(emailBox);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox emailBox;
        private Label label5;
        private Label label6;
        private Label label10;
        private Label label12;
        private Label label7;
        private Label label8;
        private Button button2;
        private DateTimePicker dateBox;
        private Label label9;
        private Button SerchBut;
        private ComboBox countyBox;
        private BindingSource personBindingSource;
        private ComboBox genBox;
        private ComboBox emissionBox;
        private ComboBox coverageBox;
        private ComboBox modelBox;
        private MaskedTextBox phoneBox;
        private TextBox nameBox;
        private DateTimePicker dateOfBirthBox;
    }
}