using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Project_Management
{
    public partial class Login : Form
    {
        Auth auth = new Auth();
        Register signup;
        public Login(Register signup)
        {
            InitializeComponent();
            this.signup = signup;
        }

        private void btn1_Load(object sender, EventArgs e)
        {
            LoginBtn.main.Click += new System.EventHandler(login_Click);
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
        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Password.Txt.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void login_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Txt.Text;
            int userId = LoginBtn.GetUserID(username);
            string password = Password.Txt.Text.Trim();
            string passwordHash = ComputeSha256Hash(password);
            if ((usernameTxt.Txt.Text == null || usernameTxt.Txt.Text == "") && (Password.Txt.Text == null || Password.Txt.Text == ""))
            {
                MessageBox.Show("Please fill all the fields", "Error");
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(auth.constring))
                {
                    try
                    {
                        conn.Open();
                        string qry = "SELECT * FROM `users` WHERE Username = @user && Password = @pass";
                        using (MySqlCommand cmd = new MySqlCommand(qry, conn))
                        {
                            cmd.Parameters.AddWithValue("@user", username);
                            cmd.Parameters.AddWithValue("@pass", passwordHash);

                            MySqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                MessageBox.Show("Welcome back, " + reader.GetString("Username"), "Logged in sucessfully!");
                                Home home = new Home(reader.GetString("Username"), userId);
                                home.Show();
                                conn.Close();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Wrong Username or Password", "Error");
                                conn.Close();
                            }
                        }

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("An Error occured: " + ex.Message, "Error");
                    }
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            signup.Show();
        }

        private void usernameTxt_Load(object sender, EventArgs e)
        {
            usernameTxt.Txt.KeyDown += username_KeyDown;
        }

        private void Password_Load(object sender, EventArgs e)
        {
            Password.Txt.KeyDown += Password_KeyDown;
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn.main.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}