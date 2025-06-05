namespace WinFormsApp11
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            labelWelcome = new Label();
            labelBalance = new Label();
            label2 = new Label();
            textBoxUsername = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            checkedListBox2 = new CheckedListBox();
            buy1 = new Button();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            buy2 = new Button();
            buy3 = new Button();
            cart = new Button();
            curs = new Button();
            profil = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(387, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 38);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(361, 38);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(543, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(153, 38);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.BackColor = Color.FromArgb(25, 25, 25);
            labelWelcome.ForeColor = SystemColors.Control;
            labelWelcome.Location = new Point(546, 30);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(38, 15);
            labelWelcome.TabIndex = 7;
            labelWelcome.Text = "label1";
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.BackColor = Color.FromArgb(25, 25, 5);
            labelBalance.ForeColor = SystemColors.Control;
            labelBalance.Location = new Point(399, 30);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(38, 15);
            labelBalance.TabIndex = 8;
            labelBalance.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(25, 25, 25);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(34, 30);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 9;
            label2.Text = "Поиск:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.FromArgb(26, 26, 24);
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.ForeColor = SystemColors.Menu;
            textBoxUsername.Location = new Point(85, 30);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(279, 16);
            textBoxUsername.TabIndex = 10;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(20, 190);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(154, 246);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(180, 77);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(203, 376);
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(20, 77);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(154, 112);
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // checkedListBox2
            // 
            checkedListBox2.BackColor = Color.FromArgb(25, 25, 25);
            checkedListBox2.BorderStyle = BorderStyle.None;
            checkedListBox2.ForeColor = SystemColors.Menu;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Приставки", "Телефоны", "Диски ", "джойстики" });
            checkedListBox2.Location = new Point(29, 97);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(96, 72);
            checkedListBox2.TabIndex = 16;
            // 
            // buy1
            // 
            buy1.BackColor = Color.FromArgb(25, 25, 5);
            buy1.FlatStyle = FlatStyle.Flat;
            buy1.ForeColor = Color.FromArgb(46, 42, 42);
            buy1.Image = (Image)resources.GetObject("buy1.Image");
            buy1.Location = new Point(202, 352);
            buy1.Name = "buy1";
            buy1.Size = new Size(159, 51);
            buy1.TabIndex = 19;
            buy1.UseVisualStyleBackColor = false;
            buy1.Click += buy1_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(383, 85);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(212, 376);
            pictureBox7.TabIndex = 20;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(584, 77);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(214, 376);
            pictureBox8.TabIndex = 21;
            pictureBox8.TabStop = false;
            // 
            // buy2
            // 
            buy2.BackColor = Color.FromArgb(25, 25, 5);
            buy2.FlatStyle = FlatStyle.Flat;
            buy2.ForeColor = Color.FromArgb(46, 42, 42);
            buy2.Image = (Image)resources.GetObject("buy2.Image");
            buy2.Location = new Point(403, 352);
            buy2.Name = "buy2";
            buy2.Size = new Size(159, 51);
            buy2.TabIndex = 22;
            buy2.UseVisualStyleBackColor = false;
            buy2.Click += buy2_Click;
            // 
            // buy3
            // 
            buy3.BackColor = Color.FromArgb(25, 25, 5);
            buy3.FlatStyle = FlatStyle.Flat;
            buy3.ForeColor = Color.FromArgb(46, 42, 42);
            buy3.Image = (Image)resources.GetObject("buy3.Image");
            buy3.Location = new Point(604, 352);
            buy3.Name = "buy3";
            buy3.Size = new Size(159, 51);
            buy3.TabIndex = 23;
            buy3.UseVisualStyleBackColor = false;
            // 
            // cart
            // 
            cart.FlatStyle = FlatStyle.Flat;
            cart.Image = (Image)resources.GetObject("cart.Image");
            cart.Location = new Point(715, 14);
            cart.Name = "cart";
            cart.Size = new Size(56, 50);
            cart.TabIndex = 24;
            cart.UseVisualStyleBackColor = true;
            cart.Click += cart_Click;
            // 
            // curs
            // 
            curs.FlatStyle = FlatStyle.Flat;
            curs.ForeColor = Color.FromArgb(19, 19, 19);
            curs.Image = (Image)resources.GetObject("curs.Image");
            curs.Location = new Point(18, 195);
            curs.Name = "curs";
            curs.Size = new Size(156, 42);
            curs.TabIndex = 25;
            curs.UseVisualStyleBackColor = true;
            curs.Click += curs_Click;
            // 
            // profil
            // 
            profil.FlatStyle = FlatStyle.Flat;
            profil.ForeColor = Color.FromArgb(19, 19, 19);
            profil.Image = (Image)resources.GetObject("profil.Image");
            profil.Location = new Point(20, 252);
            profil.Name = "profil";
            profil.Size = new Size(156, 42);
            profil.TabIndex = 26;
            profil.UseVisualStyleBackColor = true;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 12);
            ClientSize = new Size(800, 450);
            Controls.Add(profil);
            Controls.Add(curs);
            Controls.Add(cart);
            Controls.Add(buy3);
            Controls.Add(buy2);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(buy1);
            Controls.Add(checkedListBox2);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(labelBalance);
            Controls.Add(labelWelcome);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "AccountForm";
            Text = "AccountForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label labelWelcome;
        private Label labelBalance;
        private Label label2;
        private TextBox textBoxUsername;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private CheckedListBox checkedListBox2;
        private Button pokupki;
        private Button buy1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Button buy2;
        private Button buy3;
        private Button cart;
        private Button curs;
        private Button profil;
    }
}