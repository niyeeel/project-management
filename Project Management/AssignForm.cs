using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using Project_Management.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management
{
    public partial class AssignForm : Form
    {
        Auth auth = new Auth();
        TaskCreate mForm;
        private int projID;
        public AssignForm(TaskCreate mform, int ProjectId)
        {
            InitializeComponent();
            this.mForm = mform;
            this.projID = ProjectId;
        }
        private bool CheckIfUserAdded(string username)
        {
            foreach (AssignedCard m in mForm.AssignedList.Controls)
            {
                if (m.Username.Text == username)
                {
                    return true;
                }
            }
            return false;
        }

        private void btn1_Load(object sender, EventArgs e)
        {
            btn1.main.Click += Main_Click;
        }

        private void Main_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(auth.constring))
                {
                    conn.Open();
                    string qry = "SELECT * FROM `projects` " +
                        "INNER JOIN projectmembers ON projectmembers.ProjectId = projects.ProjectId " +
                        "INNER JOIN users ON users.Id = projectmembers.UserId WHERE Username = @user && projects.ProjectId = @projID";
                    using (MySqlCommand cmd = new MySqlCommand(qry, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@projID", projID);
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
                                AssignedCard membersCard = new AssignedCard();
                                membersCard.Username.Text = user;
                                membersCard.UserLTR.Letter.Text = user.Substring(0, 1).ToUpper();
                                mForm.AssignedList.Controls.Add(membersCard);
                                conn.Close();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Can't Find The Member", "Error");
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
}
