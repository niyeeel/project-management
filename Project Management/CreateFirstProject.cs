using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Project_Management.Components;
using System;
using System.Windows.Forms;

namespace Project_Management
{
    public partial class CreateFirstProject : Form
    {
        Auth auth = new Auth();
        private string user;
        public CreateFirstProject(string user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void CreateFirstProject_Load(object sender, EventArgs e)
        {
            Username.Text = this.user;
            UserLTR.Letter.Text = this.user.Substring(0, 1).ToUpper();
        }
        private void addBtn1_Load(object sender, EventArgs e)
        {
            addBtn1.Btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember(this);
            addMember.ShowDialog();
        }

        private void btn1_Load_1(object sender, EventArgs e)
        {
            btn1.main.Click += Main_Click;
        }
        public void MinusBtn_Click(object sender, EventArgs e)
        {
            Guna2ImageButton Btn = (Guna2ImageButton)sender;
            if (Btn.Parent is MembersCard)
            {
                MembersCard parent = (MembersCard)Btn.Parent;
                if (MembersList.Controls.Contains(parent))
                {
                    MembersList.Controls.Remove(parent);
                }
            }
        }
        private int MemberCounter()
        {
            int Members = 1;
            foreach(MembersCard members in MembersList.Controls)
            {
                Members++;
            }
            return Members;
        }
        private void Main_Click(object sender, EventArgs e)
        {
            string ProjectName = NameTxt.Text;
            DateTime ProjectStart = PRstart.Value;
            DateTime ProjectEnd = PRend.Value;
            string Prstart = ProjectStart.ToString("yyyy-MM-dd");
            string Prend = ProjectEnd.ToString("yyyy-MM-dd");
            string ProjectDescription = DescTxt.Text;
            if (ProjectName == null || ProjectName == "")
            {
                MessageBox.Show("Please provide a project name");
            }
            else if (PRstart.Value == PRend.Value)
            {
                MessageBox.Show("Please Provide a valid dates");
            }else
            {
                if (ProjectDescription == null || ProjectDescription == "")
                {
                    ProjectDescription = "This project's manager is too lazy to put a description";
                }
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(auth.constring))
                    {
                        conn.Open();
                        int userid = btn1.GetUserID(user);
                        if (userid != 0)
                        {
                            string qry = "INSERT INTO `projects`(`ProjectName`,`ManagerId`, `ProjectStart`, `ProjectEnd`, `ProjectDescription`, `MemberNum`, `TasksNum`)" +
                            " VALUES (?,?, ?, ?, ?, ?, ?)";
                            string qry2 = "SELECT * FROM `projects` WHERE ProjectName = @proj && ManagerId = @id";
                            using (MySqlCommand commd = new MySqlCommand(qry2, conn))
                            {
                                commd.Parameters.AddWithValue("@proj", ProjectName);
                                commd.Parameters.AddWithValue("@id", userid);
                                MySqlDataReader reader = commd.ExecuteReader();
                                if (reader.Read())
                                {
                                    MessageBox.Show("Project is Already existed");
                                }
                                else
                                {
                                    reader.Close();
                                    using (MySqlCommand cmd = new MySqlCommand(qry, conn))
                                    {
                                        cmd.Parameters.AddWithValue("param1", ProjectName);
                                        cmd.Parameters.AddWithValue("param2", userid);
                                        cmd.Parameters.AddWithValue("param3", Prstart);
                                        cmd.Parameters.AddWithValue("param4", Prend);
                                        cmd.Parameters.AddWithValue("param5", ProjectDescription);
                                        cmd.Parameters.AddWithValue("param6", MemberCounter());
                                        cmd.Parameters.AddWithValue("param7", 0);
                                        int insert = cmd.ExecuteNonQuery();
                                        if (insert > 0)
                                        {
                                            try
                                            {
                                                using (MySqlConnection con = new MySqlConnection(auth.constring))
                                                {
                                                    con.Open();
                                                    using (MySqlCommand comd = new MySqlCommand(qry2, con))
                                                    {
                                                        comd.Parameters.AddWithValue("@proj", ProjectName);
                                                        comd.Parameters.AddWithValue("@id", userid);
                                                        MySqlDataReader reader2 = comd.ExecuteReader();
                                                        if (reader2.Read())
                                                        {
                                                            int ProjId = reader2.GetInt32("ProjectId");
                                                            btn1.AssignMembers(ProjId, userid, Role.Text);
                                                            foreach (MembersCard c in MembersList.Controls)
                                                            {
                                                                btn1.AssignMembers(ProjId, btn1.GetUserID(c.Username.Text), c.Role.Text);
                                                            }
                                                            MessageBox.Show("Project Created Successfully!", "Hooray");
                                                            Home home = new Home(user, userid);
                                                            home.Show();
                                                            reader2.Close();
                                                            this.Close();
                                                            con.Close();
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Project Creation Failed", "Error");
                                                            con.Close();
                                                        }
                                                    }
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("Project Creation Failed: " + ex.Message, "Error");
                                            }
                                        }
                                    }
                                    conn.Close();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("User is not available", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured: " + ex.Message, "Error");
                }
            }
        }

        private void NextBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int userid = btn1.GetUserID(user);
            Home home = new Home(user, userid);
            home.Show();
        }
    }
}