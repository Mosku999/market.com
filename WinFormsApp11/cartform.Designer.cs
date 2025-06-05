namespace WinFormsApp11
{
    partial class profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile));
            listBoxCart = new ListBox();
            labelTotal = new Label();
            buttonClear = new Button();
            buttonCheckout = new Button();
            buttonClose = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxCart
            // 
            listBoxCart.FormattingEnabled = true;
            listBoxCart.ItemHeight = 15;
            listBoxCart.Location = new Point(230, 88);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new Size(120, 94);
            listBoxCart.TabIndex = 0;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.ForeColor = SystemColors.ControlLightLight;
            labelTotal.Location = new Point(416, 30);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(38, 15);
            labelTotal.TabIndex = 1;
            labelTotal.Text = "label1";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(338, 234);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 2;
            buttonClear.Text = "button1";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonCheckout
            // 
            buttonCheckout.Location = new Point(338, 279);
            buttonCheckout.Name = "buttonCheckout";
            buttonCheckout.Size = new Size(75, 23);
            buttonCheckout.TabIndex = 3;
            buttonCheckout.Text = "button2";
            buttonCheckout.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(319, 336);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "button3";
            buttonClose.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 75);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // profile
            // 
            BackColor = Color.FromArgb(14, 14, 12);
            ClientSize = new Size(798, 445);
            Controls.Add(pictureBox1);
            Name = "profile";
            Load += cartform_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxCart;
        private Label labelTotal;
        private Button buttonClear;
        private Button buttonCheckout;
        private Button buttonClose;
        private PictureBox pictureBox1;
    }
}