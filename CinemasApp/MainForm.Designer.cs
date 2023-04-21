namespace CinemasApp
{
    partial class MainForm
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
            buttonCinema = new Button();
            buttonAdd = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // buttonCinema
            // 
            buttonCinema.Location = new Point(12, 12);
            buttonCinema.Name = "buttonCinema";
            buttonCinema.Size = new Size(269, 40);
            buttonCinema.TabIndex = 0;
            buttonCinema.Text = "Кінотеатри";
            buttonCinema.UseVisualStyleBackColor = true;
            buttonCinema.Click += buttonCinema_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 58);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(269, 40);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(12, 104);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(269, 40);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Вийти";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(293, 157);
            Controls.Add(buttonExit);
            Controls.Add(buttonAdd);
            Controls.Add(buttonCinema);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Головна";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCinema;
        private Button buttonAdd;
        private Button buttonExit;
    }
}