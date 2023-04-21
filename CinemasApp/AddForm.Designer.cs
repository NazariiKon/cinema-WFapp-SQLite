namespace CinemasApp
{
    partial class AddForm
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
            tabControl1 = new TabControl();
            tabPageAddCinema = new TabPage();
            numericUpDownHalls = new NumericUpDown();
            numericUpDownCount = new NumericUpDown();
            comboBoxCategory = new ComboBox();
            buttonAddCinema = new Button();
            textBoxName = new TextBox();
            textBoxArea = new TextBox();
            textBoxStreet = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            tabPageAddFilm = new TabPage();
            buttonAddFilm = new Button();
            textBoxFilm = new TextBox();
            comboBoxGenre = new ComboBox();
            label13 = new Label();
            richTextBoxActors = new RichTextBox();
            textBoxAwards = new TextBox();
            textBoxOperator = new TextBox();
            textBoxDirector = new TextBox();
            textBoxDuration = new TextBox();
            label2 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tabPageAddSession = new TabPage();
            buttonAddSession = new Button();
            numericUpDownHall = new NumericUpDown();
            label18 = new Label();
            numericUpDownPrice = new NumericUpDown();
            label17 = new Label();
            label16 = new Label();
            dateTimePicker = new DateTimePicker();
            comboBoxFilm = new ComboBox();
            comboBoxCinema = new ComboBox();
            label15 = new Label();
            label14 = new Label();
            tabControl1.SuspendLayout();
            tabPageAddCinema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHalls).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).BeginInit();
            tabPageAddFilm.SuspendLayout();
            tabPageAddSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageAddCinema);
            tabControl1.Controls.Add(tabPageAddFilm);
            tabControl1.Controls.Add(tabPageAddSession);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(356, 329);
            tabControl1.TabIndex = 0;
            // 
            // tabPageAddCinema
            // 
            tabPageAddCinema.Controls.Add(numericUpDownHalls);
            tabPageAddCinema.Controls.Add(numericUpDownCount);
            tabPageAddCinema.Controls.Add(comboBoxCategory);
            tabPageAddCinema.Controls.Add(buttonAddCinema);
            tabPageAddCinema.Controls.Add(textBoxName);
            tabPageAddCinema.Controls.Add(textBoxArea);
            tabPageAddCinema.Controls.Add(textBoxStreet);
            tabPageAddCinema.Controls.Add(label6);
            tabPageAddCinema.Controls.Add(label7);
            tabPageAddCinema.Controls.Add(label5);
            tabPageAddCinema.Controls.Add(label4);
            tabPageAddCinema.Controls.Add(label3);
            tabPageAddCinema.Controls.Add(label1);
            tabPageAddCinema.Location = new Point(4, 29);
            tabPageAddCinema.Name = "tabPageAddCinema";
            tabPageAddCinema.Padding = new Padding(3);
            tabPageAddCinema.Size = new Size(348, 296);
            tabPageAddCinema.TabIndex = 0;
            tabPageAddCinema.Text = "Додати кінотеатр";
            tabPageAddCinema.UseVisualStyleBackColor = true;
            // 
            // numericUpDownHalls
            // 
            numericUpDownHalls.Location = new Point(116, 213);
            numericUpDownHalls.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownHalls.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownHalls.Name = "numericUpDownHalls";
            numericUpDownHalls.Size = new Size(226, 27);
            numericUpDownHalls.TabIndex = 64;
            numericUpDownHalls.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownCount
            // 
            numericUpDownCount.Location = new Point(116, 173);
            numericUpDownCount.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDownCount.Name = "numericUpDownCount";
            numericUpDownCount.Size = new Size(226, 27);
            numericUpDownCount.TabIndex = 63;
            numericUpDownCount.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(116, 132);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(226, 28);
            comboBoxCategory.TabIndex = 55;
            // 
            // buttonAddCinema
            // 
            buttonAddCinema.Location = new Point(6, 261);
            buttonAddCinema.Name = "buttonAddCinema";
            buttonAddCinema.Size = new Size(336, 29);
            buttonAddCinema.TabIndex = 35;
            buttonAddCinema.Text = "Додати";
            buttonAddCinema.UseVisualStyleBackColor = true;
            buttonAddCinema.Click += buttonAddCinema_Click;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(116, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(226, 27);
            textBoxName.TabIndex = 34;
            // 
            // textBoxArea
            // 
            textBoxArea.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxArea.Location = new Point(116, 52);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(226, 27);
            textBoxArea.TabIndex = 33;
            // 
            // textBoxStreet
            // 
            textBoxStreet.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStreet.Location = new Point(116, 92);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(226, 27);
            textBoxStreet.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(7, 135);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 28;
            label6.Text = "Категорія:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(7, 215);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 27;
            label7.Text = "К-ть залів:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(7, 175);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 26;
            label5.Text = "К-ть місць:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 95);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 25;
            label4.Text = "Вулиця:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 55);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 24;
            label3.Text = "Район:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 23;
            label1.Text = "Назва: ";
            // 
            // tabPageAddFilm
            // 
            tabPageAddFilm.Controls.Add(buttonAddFilm);
            tabPageAddFilm.Controls.Add(textBoxFilm);
            tabPageAddFilm.Controls.Add(comboBoxGenre);
            tabPageAddFilm.Controls.Add(label13);
            tabPageAddFilm.Controls.Add(richTextBoxActors);
            tabPageAddFilm.Controls.Add(textBoxAwards);
            tabPageAddFilm.Controls.Add(textBoxOperator);
            tabPageAddFilm.Controls.Add(textBoxDirector);
            tabPageAddFilm.Controls.Add(textBoxDuration);
            tabPageAddFilm.Controls.Add(label2);
            tabPageAddFilm.Controls.Add(label8);
            tabPageAddFilm.Controls.Add(label9);
            tabPageAddFilm.Controls.Add(label10);
            tabPageAddFilm.Controls.Add(label11);
            tabPageAddFilm.Controls.Add(label12);
            tabPageAddFilm.Location = new Point(4, 29);
            tabPageAddFilm.Name = "tabPageAddFilm";
            tabPageAddFilm.Padding = new Padding(3);
            tabPageAddFilm.Size = new Size(348, 296);
            tabPageAddFilm.TabIndex = 1;
            tabPageAddFilm.Text = "Додати фільм";
            tabPageAddFilm.UseVisualStyleBackColor = true;
            // 
            // buttonAddFilm
            // 
            buttonAddFilm.Location = new Point(6, 261);
            buttonAddFilm.Name = "buttonAddFilm";
            buttonAddFilm.Size = new Size(336, 29);
            buttonAddFilm.TabIndex = 56;
            buttonAddFilm.Text = "Додати";
            buttonAddFilm.UseVisualStyleBackColor = true;
            buttonAddFilm.Click += buttonAddFilm_Click;
            // 
            // textBoxFilm
            // 
            textBoxFilm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFilm.Location = new Point(131, 6);
            textBoxFilm.Name = "textBoxFilm";
            textBoxFilm.Size = new Size(211, 27);
            textBoxFilm.TabIndex = 55;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(131, 37);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(211, 28);
            comboBoxGenre.TabIndex = 54;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 9);
            label13.Name = "label13";
            label13.Size = new Size(54, 20);
            label13.TabIndex = 53;
            label13.Text = "Назва:";
            // 
            // richTextBoxActors
            // 
            richTextBoxActors.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxActors.Location = new Point(131, 104);
            richTextBoxActors.Name = "richTextBoxActors";
            richTextBoxActors.Size = new Size(211, 48);
            richTextBoxActors.TabIndex = 52;
            richTextBoxActors.Text = "";
            // 
            // textBoxAwards
            // 
            textBoxAwards.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAwards.Location = new Point(131, 224);
            textBoxAwards.Name = "textBoxAwards";
            textBoxAwards.Size = new Size(211, 27);
            textBoxAwards.TabIndex = 51;
            // 
            // textBoxOperator
            // 
            textBoxOperator.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOperator.Location = new Point(131, 191);
            textBoxOperator.Name = "textBoxOperator";
            textBoxOperator.Size = new Size(211, 27);
            textBoxOperator.TabIndex = 50;
            // 
            // textBoxDirector
            // 
            textBoxDirector.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDirector.Location = new Point(131, 158);
            textBoxDirector.Name = "textBoxDirector";
            textBoxDirector.Size = new Size(211, 27);
            textBoxDirector.TabIndex = 49;
            // 
            // textBoxDuration
            // 
            textBoxDuration.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDuration.Location = new Point(131, 71);
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.Size = new Size(211, 27);
            textBoxDuration.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 227);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 47;
            label2.Text = "Нагороди:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 40);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 46;
            label8.Text = "Жанр:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(6, 194);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 45;
            label9.Text = "Оператор:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(6, 161);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 44;
            label10.Text = "Режисер:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(6, 107);
            label11.Name = "label11";
            label11.Size = new Size(122, 20);
            label11.TabIndex = 43;
            label11.Text = "Головні актори: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(6, 74);
            label12.Name = "label12";
            label12.Size = new Size(91, 20);
            label12.TabIndex = 42;
            label12.Text = "Тривалість: ";
            // 
            // tabPageAddSession
            // 
            tabPageAddSession.Controls.Add(buttonAddSession);
            tabPageAddSession.Controls.Add(numericUpDownHall);
            tabPageAddSession.Controls.Add(label18);
            tabPageAddSession.Controls.Add(numericUpDownPrice);
            tabPageAddSession.Controls.Add(label17);
            tabPageAddSession.Controls.Add(label16);
            tabPageAddSession.Controls.Add(dateTimePicker);
            tabPageAddSession.Controls.Add(comboBoxFilm);
            tabPageAddSession.Controls.Add(comboBoxCinema);
            tabPageAddSession.Controls.Add(label15);
            tabPageAddSession.Controls.Add(label14);
            tabPageAddSession.Location = new Point(4, 29);
            tabPageAddSession.Name = "tabPageAddSession";
            tabPageAddSession.Size = new Size(348, 296);
            tabPageAddSession.TabIndex = 2;
            tabPageAddSession.Text = "Додати сеанс";
            tabPageAddSession.UseVisualStyleBackColor = true;
            // 
            // buttonAddSession
            // 
            buttonAddSession.Location = new Point(3, 264);
            buttonAddSession.Name = "buttonAddSession";
            buttonAddSession.Size = new Size(342, 29);
            buttonAddSession.TabIndex = 65;
            buttonAddSession.Text = "Додати";
            buttonAddSession.UseVisualStyleBackColor = true;
            buttonAddSession.Click += buttonAddSession_Click;
            // 
            // numericUpDownHall
            // 
            numericUpDownHall.Location = new Point(139, 153);
            numericUpDownHall.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownHall.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownHall.Name = "numericUpDownHall";
            numericUpDownHall.Size = new Size(206, 27);
            numericUpDownHall.TabIndex = 62;
            numericUpDownHall.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 160);
            label18.Name = "label18";
            label18.Size = new Size(36, 20);
            label18.TabIndex = 61;
            label18.Text = "Зал:";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(139, 120);
            numericUpDownPrice.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownPrice.Minimum = new decimal(new int[] { 80, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(206, 27);
            numericUpDownPrice.TabIndex = 60;
            numericUpDownPrice.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 127);
            label17.Name = "label17";
            label17.Size = new Size(44, 20);
            label17.TabIndex = 59;
            label17.Text = "Ціна:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 92);
            label16.Name = "label16";
            label16.Size = new Size(44, 20);
            label16.TabIndex = 58;
            label16.Text = "Дата:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(139, 87);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(206, 27);
            dateTimePicker.TabIndex = 57;
            // 
            // comboBoxFilm
            // 
            comboBoxFilm.FormattingEnabled = true;
            comboBoxFilm.Location = new Point(139, 53);
            comboBoxFilm.Name = "comboBoxFilm";
            comboBoxFilm.Size = new Size(206, 28);
            comboBoxFilm.TabIndex = 56;
            // 
            // comboBoxCinema
            // 
            comboBoxCinema.FormattingEnabled = true;
            comboBoxCinema.Location = new Point(139, 19);
            comboBoxCinema.Name = "comboBoxCinema";
            comboBoxCinema.Size = new Size(206, 28);
            comboBoxCinema.TabIndex = 55;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 22);
            label15.Name = "label15";
            label15.Size = new Size(84, 20);
            label15.TabIndex = 1;
            label15.Text = "Кінотеатр: ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 56);
            label14.Name = "label14";
            label14.Size = new Size(58, 20);
            label14.TabIndex = 0;
            label14.Text = "Фільм: ";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(382, 353);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddForm";
            Text = "Додавання";
            tabControl1.ResumeLayout(false);
            tabPageAddCinema.ResumeLayout(false);
            tabPageAddCinema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHalls).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).EndInit();
            tabPageAddFilm.ResumeLayout(false);
            tabPageAddFilm.PerformLayout();
            tabPageAddSession.ResumeLayout(false);
            tabPageAddSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHall).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageAddCinema;
        private TabPage tabPageAddFilm;
        private TabPage tabPageAddSession;
        private Button buttonAddCinema;
        private TextBox textBoxName;
        private TextBox textBoxArea;
        private TextBox textBoxStreet;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox textBoxFilm;
        private ComboBox comboBoxGenre;
        private Label label13;
        private RichTextBox richTextBoxActors;
        private TextBox textBoxAwards;
        private TextBox textBoxOperator;
        private TextBox textBoxDirector;
        private TextBox textBoxDuration;
        private Label label2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button buttonAddFilm;
        private NumericUpDown numericUpDownPrice;
        private Label label17;
        private Label label16;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBoxFilm;
        private ComboBox comboBoxCinema;
        private Label label15;
        private Label label14;
        private Button buttonAddSession;
        private ComboBox comboBoxCategory;
        private NumericUpDown numericUpDownHall;
        private Label label18;
        private NumericUpDown numericUpDownHalls;
        private NumericUpDown numericUpDownCount;
    }
}