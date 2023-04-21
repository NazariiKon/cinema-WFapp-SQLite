namespace CinemasApp
{
    partial class CinemaInfoForm
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
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBoxCount = new TextBox();
            textBoxHalls = new TextBox();
            textBoxCategory = new TextBox();
            textBoxStreet = new TextBox();
            textBoxArea = new TextBox();
            textBoxName = new TextBox();
            listBoxRepertuar = new ListBox();
            label2 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(19, 189);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(103, 28);
            label6.TabIndex = 16;
            label6.Text = "Категорія:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(19, 269);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(105, 28);
            label7.TabIndex = 15;
            label7.Text = "К-ть залів:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 229);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 28);
            label5.TabIndex = 14;
            label5.Text = "К-ть місць:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 149);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 13;
            label4.Text = "Вулиця:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 109);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 12;
            label3.Text = "Район:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 11;
            label1.Text = "Назва: ";
            // 
            // textBoxCount
            // 
            textBoxCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCount.Location = new Point(135, 226);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.ReadOnly = true;
            textBoxCount.Size = new Size(235, 34);
            textBoxCount.TabIndex = 17;
            // 
            // textBoxHalls
            // 
            textBoxHalls.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxHalls.Location = new Point(135, 266);
            textBoxHalls.Name = "textBoxHalls";
            textBoxHalls.ReadOnly = true;
            textBoxHalls.Size = new Size(235, 34);
            textBoxHalls.TabIndex = 18;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCategory.Location = new Point(135, 186);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.ReadOnly = true;
            textBoxCategory.Size = new Size(235, 34);
            textBoxCategory.TabIndex = 19;
            // 
            // textBoxStreet
            // 
            textBoxStreet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStreet.Location = new Point(135, 146);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.ReadOnly = true;
            textBoxStreet.Size = new Size(235, 34);
            textBoxStreet.TabIndex = 20;
            // 
            // textBoxArea
            // 
            textBoxArea.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxArea.Location = new Point(135, 106);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.ReadOnly = true;
            textBoxArea.Size = new Size(235, 34);
            textBoxArea.TabIndex = 21;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(135, 66);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(235, 34);
            textBoxName.TabIndex = 22;
            // 
            // listBoxRepertuar
            // 
            listBoxRepertuar.FormattingEnabled = true;
            listBoxRepertuar.ItemHeight = 20;
            listBoxRepertuar.Location = new Point(377, 56);
            listBoxRepertuar.Margin = new Padding(4, 3, 4, 3);
            listBoxRepertuar.Name = "listBoxRepertuar";
            listBoxRepertuar.Size = new Size(584, 244);
            listBoxRepertuar.TabIndex = 23;
            listBoxRepertuar.MouseDoubleClick += listBoxRepertuar_MouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(347, 38);
            label2.TabIndex = 24;
            label2.Text = "Інформація про кінотеатр";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(368, 9);
            label8.Name = "label8";
            label8.Size = new Size(150, 38);
            label8.TabIndex = 25;
            label8.Text = "Репертуар";
            // 
            // CinemaInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 315);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(listBoxRepertuar);
            Controls.Add(textBoxName);
            Controls.Add(textBoxArea);
            Controls.Add(textBoxStreet);
            Controls.Add(textBoxCategory);
            Controls.Add(textBoxHalls);
            Controls.Add(textBoxCount);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CinemaInfoForm";
            Text = "Кінотеатр";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox textBoxCount;
        private TextBox textBoxHalls;
        private TextBox textBoxCategory;
        private TextBox textBoxStreet;
        private TextBox textBoxArea;
        private TextBox textBoxName;
        private ListBox listBoxRepertuar;
        private Label label2;
        private Label label8;
    }
}