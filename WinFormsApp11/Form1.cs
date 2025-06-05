using System;
using System.Windows.Forms;

namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        private UserManager userManager = new UserManager();

        public Form1()
        {
            InitializeComponent();
            labelStatus.Text = string.Empty;
            if (buttonRegister != null)
            {
                buttonRegister.Click += buttonLogin_Click;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя и пароль.");
                return;
            }

            if (userManager.AddUser(new User { Username = username, Password = password }))
            {
                MessageBox.Show("Аккаунт успешно создан!");
                OpenAccountForm(username);
            }
            else
            {
                MessageBox.Show("Пользователь с таким именем уже существует.");
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text;

            var user = userManager.Users.Find(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                OpenAccountForm(username);
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            buttonLogin_Click(sender, e);
        }

        private void OpenAccountForm(string username)
        {
            var user = userManager.Users.Find(u => u.Username == username);
            if (user == null) return;

            textBoxUsername.Clear();
            textBoxPassword.Clear();

            this.Hide();
            var accountForm = new AccountForm(user);
            accountForm.FormClosed += (s, args) => this.Show();
            accountForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}