namespace CinemasApp
{
    partial class CinemasForm
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
            cinemasList = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cinemasList
            // 
            cinemasList.FormattingEnabled = true;
            cinemasList.ItemHeight = 20;
            cinemasList.Location = new Point(12, 52);
            cinemasList.Name = "cinemasList";
            cinemasList.Size = new Size(458, 264);
            cinemasList.TabIndex = 5;
            cinemasList.DoubleClick += cinemasList_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(185, 28);
            label1.TabIndex = 6;
            label1.Text = "Оберіть кінотеатр: ";
            // 
            // CinemasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 329);
            Controls.Add(label1);
            Controls.Add(cinemasList);
            Name = "CinemasForm";
            Text = "Кінотеатри";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox cinemasList;
        private Label label1;
    }
}