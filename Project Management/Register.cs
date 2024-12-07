using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Project_Management
{
    public partial class Register : Form
    {

        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }


        private void btn1_Load(object sender, EventArgs e)
        {
            SignUp.main.Click += new System.EventHandler(signup_Click);
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void signup_Click(object sender, EventArgs e)
        {
            string username = username1.Txt.Text;
            string password = Password.Txt.Text.Trim();
            string passwordHash = ComputeSha256Hash(password);
            string conpass = Con_password.Txt.Text;
            if (password != conpass)
            {
                MessageBox.Show("Passwords doens't match", "Error");
            }
            else if (username.Length < 8)
            {
                MessageBox.Show("Username must be atleast 8 characters long", "Error");
            }
            else if (password.Length < 8)
            {
                MessageBox.Show("Username must be atleast 8 characters long", "Error");
            }
            else
            {
                if (SignUp.SignedUp(username, passwordHash))
                {
                    CreateFirstProject create = new CreateFirstProject(username);
                    create.Show();
                    this.Hide();
                }
            }
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void username1_Load(object sender, EventArgs e)
        {

        }

        private void password2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login(this);
            login.Show();
        }
    }
}
