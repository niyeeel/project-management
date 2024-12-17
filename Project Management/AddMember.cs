using MySql.Data.MySqlClient;
using Project_Management.Components;
using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Project_Management
{
    public partial class AddMember : Form
    {
        private Form mForm;
        Auth auth = new Auth();
        public AddMember(Form mForm)
        {
            InitializeComponent();
            this.mForm = mForm;
        }

        private void btn1_Load(object sender, EventArgs e)
        {
            btn1.main.Click += Main_Click;
        }
        private bool CheckIfUserAdded(string username)
        {
           if (mForm is CreateFirstProject createProject)
            {
                foreach (MembersCard m in createProject.MembersList.Controls)
                {
                    if (m.Username.Text == username)
                    {
                        return true;
                    }
                }
            } else if (mForm is AddNewMember addmember)
            {
                foreach (MembersCard m in addmember.NewMemberList.Controls)
                {
                    if (m.Username.Text == username)
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }

        private void Main_Click(object sender, EventArgs e)
        {
            string username = username1.Txt.Text;
            if (mForm is CreateFirstProject createForm)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(auth.constring))
                    {
                        conn.Open();
                        string qry = "SELECT * FROM `users` WHERE Username = @user";
                        using (MySqlCommand cmd = new MySqlCommand(qry, conn))
                        {
                            cmd.Parameters.AddWithValue("@user", username);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                string user = reader.GetString("Username");
                                if (CheckIfUserAdded(user))
                                {
                                    MessageBox.Show("You already added this member");
                                }
                                else
                                {
                                    MembersCard membersCard = new MembersCard();
                                    membersCard.Username.Text = user;
                                    membersCard.UserLTR.Letter.Text = user.Substring(0, 1).ToUpper();
                                    membersCard.MinusBtn.Click += createForm.MinusBtn_Click;
                                    createForm.MembersList.Controls.Add(membersCard);
                                    conn.Close();
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Can't Find The User", "Error");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured: " + ex.Message, "Error");
                }
            } else if (mForm is AddNewMember addForm)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(auth.constring))
                    {
                        conn.Open();
                        string qry = "SELECT * FROM `users` WHERE Username = @user";
                        using (MySqlCommand cmd = new MySqlCommand(qry, conn))
                        {
                            cmd.Parameters.AddWithValue("@user", username);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                string user = reader.GetString("Username");
                                if (CheckIfUserAdded(user))
                                {
                                    MessageBox.Show("You already added this member");
                                }
                                else
                                {
                                    MembersCard membersCard = new MembersCard();
                                    membersCard.Username.Text = user;
                                    membersCard.UserLTR.Letter.Text = user.Substring(0, 1).ToUpper();
                                    membersCard.MinusBtn.Click += addForm.MinusBtn_Click;
                                    addForm.NewMemberList.Controls.Add(membersCard);
                                    conn.Close();
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Can't Find The User", "Error");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured: " + ex.Message, "Error");
                }
            }
           
        }

        private void AddMember_Load(object sender, EventArgs e)
        {

        }
    }
}
