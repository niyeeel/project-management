using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Project_Management.Components;

namespace Project_Management
{
    public partial class AddNewMember : Form
    {
        Auth auth = new Auth();
        private int ProjectID;
        private int userid;
        private string name;
        
        public AddNewMember(int projId, int userID, string username)
        {
            InitializeComponent();
            this.ProjectID = projId;
            this.userid = userID;
            this.name = username;
        }

        private void PanelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private int CurrentMembersNum()
        {
            int membersNum = 0;
            foreach(MembersCard mcard in MembersList.Controls)
            {
                membersNum++;
            }
            return membersNum;
        }
        int MembersNum;
        private void AddNewMember_Load(object sender, EventArgs e)
        {
            MembersNum = CurrentMembersNum();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(auth.constring))
                {
                    conn.Open();
                    string qry = "SELECT * FROM projectmembers WHERE UserId = @userid" ;
                    string qry2 = "SELECT * FROM `projectmembers` JOIN users ON users.Id = projectmembers.UserId WHERE ProjectId = @projID && UserId != @user";
                    using (MySqlCommand cmd = new MySqlCommand(qry, conn))
                    {
                        cmd.Parameters.AddWithValue("@userid", userid);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Username.Text = name;
                            Role.Text = reader.GetString("Role");
                            UserLTR.Letter.Text = name.Substring(0, 1).ToUpper();
                        }
                        reader.Close();
                    }
                    using (MySqlCommand cmd2 = new MySqlCommand(qry2, conn))
                    {
                        cmd2.Parameters.AddWithValue("@projID", ProjectID);
                        cmd2.Parameters.AddWithValue("@user", userid);
                        MySqlDataReader reader2 = cmd2.ExecuteReader();
                        while (reader2.Read())
                        {
                            MembersCard card = new MembersCard();
                            card.Username.Text = reader2.GetString("Username");
                            card.Role.Text = reader2.GetString("Role");
                            card.UserLTR.Letter.Text = reader2.GetString("Username").Substring(0, 1).ToUpper();
                            card.MinusBtn.Click += MinusBtn_Click1;
                            MembersList.Controls.Add(card);
                        }
                        reader2.Close();
                    }
                    conn.Close();
                }
            } catch
            {
                MessageBox.Show("An Error Occured");
            }
        }
        List<string> removeMember = new List<string>();
        private void MinusBtn_Click1(object sender, EventArgs e)
        {
            Guna2ImageButton Btn = (Guna2ImageButton)sender;
            if (Btn.Parent is MembersCard)
            {
                MembersCard parent = (MembersCard)Btn.Parent;
                if (MembersList.Controls.Contains(parent))
                {
                    MembersList.Controls.Remove(parent);
                    removeMember.Add(parent.Username.Text);
                }
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addBtn1_Load(object sender, EventArgs e)
        {
            addBtn1.Btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            AddMember add = new AddMember(this);
            add.ShowDialog();
        }

        public void MinusBtn_Click(object sender, EventArgs e)
        {
            Guna2ImageButton Btn = (Guna2ImageButton)sender;
            if (Btn.Parent is MembersCard)
            {
                MembersCard parent = (MembersCard)Btn.Parent;
                if (NewMemberList.Controls.Contains(parent))
                {
                    NewMemberList.Controls.Remove(parent);
                }
            }
        }

        private void btn2_Load(object sender, EventArgs e)
        {
            btn2.main.Click += Main_Click;
        }

        private void Main_Click(object sender, EventArgs e)
        {
            if (removeMember != null)
            {
                using (MySqlConnection conn = new MySqlConnection(auth.constring))
                {
                    conn.Open();
                    string qry3 = "DELETE projectmembers FROM projectmembers INNER JOIN users ON projectmembers.UserId = users.Id WHERE projectmembers.ProjectId = @projID AND users.Username = @user;";
                    foreach (string user in removeMember)
                    {
                        using (MySqlCommand cmd3 = new MySqlCommand(qry3, conn))
                        {
                            cmd3.Parameters.AddWithValue("@projID", ProjectID);
                            cmd3.Parameters.AddWithValue("@user", user);
                            cmd3.ExecuteNonQuery();
                        }
                    }
                    conn.Close();
                }
            }
            foreach (MembersCard card in NewMemberList.Controls) {
                int iduser = 0;
                using (MySqlConnection con = new MySqlConnection(auth.constring))
                {
                    con.Open();
                    string qry = "SELECT * FROM users WHERE Username = @username";
                    string qry2 = "INSERT INTO `projectmembers`(`ProjectId`, `UserId`, `Role`) VALUES (?, ?, ?)";
                    using (MySqlCommand cmd = new MySqlCommand(qry, con))
                    {
                        cmd.Parameters.AddWithValue("@username", card.Username.Text);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read()) {
                            iduser = reader.GetInt32("Id");
                        }
                        reader.Close();
                    }
                    using (MySqlCommand cmd2 = new MySqlCommand(qry2, con))
                    {
                        cmd2.Parameters.AddWithValue("param1", ProjectID);
                        cmd2.Parameters.AddWithValue("param2", iduser);
                        cmd2.Parameters.AddWithValue("param3", card.Role.Text);
                        cmd2.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            MessageBox.Show("Members Saved");
            this.Close();
        }

        private void btn1_Load(object sender, EventArgs e)
        {
            btn1.main.Click += Main_Click1;
        }

        private void Main_Click1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
