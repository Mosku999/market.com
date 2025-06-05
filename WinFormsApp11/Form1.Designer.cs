namespace WinFormsApp11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonLogin = new Button();
            labelStatus = new Label();
            buttonRegister = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Image = (Image)resources.GetObject("buttonLogin.Image");
            buttonLogin.Location = new Point(255, 272);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(249, 45);
            buttonLogin.TabIndex = 2;
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonRegister_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(115, 103);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 15);
            labelStatus.TabIndex = 3;
            // 
            // buttonRegister
            // 
            buttonRegister.FlatStyle = FlatStyle.Popup;
            buttonRegister.Image = (Image)resources.GetObject("buttonRegister.Image");
            buttonRegister.Location = new Point(322, 331);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(122, 22);
            buttonRegister.TabIndex = 4;
            buttonRegister.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(218, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 72);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(255, 144);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(252, 50);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(255, 214);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(252, 50);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.FromArgb(46, 42, 42);
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.ForeColor = Color.Gray;
            textBoxUsername.Location = new Point(267, 155);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(222, 16);
            textBoxUsername.TabIndex = 9;
            textBoxUsername.Text = "Логин: ";
            textBoxUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(46, 42, 42);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.ForeColor = Color.Gray;
            textBoxPassword.Location = new Point(267, 225);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(222, 16);
            textBoxPassword.TabIndex = 10;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 12);
            ClientSize = new Size(763, 433);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(buttonRegister);
            Controls.Add(labelStatus);
            Controls.Add(buttonLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonLogin;
        private Label labelStatus;
        private Button buttonRegister;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
    }
}
