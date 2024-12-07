using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Project_Management.Components;

namespace Project_Management
{
    public partial class TaskOverview : Form
    {
        private readonly int TaskId;
        Auth auth = new Auth();
        private readonly string Username;
        public TaskOverview(int Taskid, string username)
        {
            InitializeComponent();
            this.TaskId = Taskid;
            this.Username = username;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string GetAssigneesName(int id)
        {
            using (MySqlConnection con = new MySqlConnection(auth.constring))
            {
                con.Open();
                string qry = "SELECT * FROM users WHERE Id = @id";
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader.GetString("Username");
                    } else
                    {
                        return null;
                    }
                }
            }
        }

        private void TaskOverview_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(auth.constring))
                {
                    con.Open();
                    string qry = "SELECT * FROM tasks WHERE id = @ID";
                    string qry2 = "SELECT * FROM taskmembers WHERE TaskId = @taskId";
                    string qry3 = "SELECT * FROM comments WHERE TaskId = @taskId";
                    using (MySqlCommand cmd = new MySqlCommand(qry, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", TaskId);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            taskName.Text = reader.GetString("TaskName");
                            Urgency.Text = reader.GetString("Urgency");
                            TagLbl.Text = reader.GetString("Tags");
                            StartDate.Text = reader.GetDateTime("TaskStart").ToString("MM/dd/yyyy");
                            DueDate.Text = reader.GetDateTime("TaskEnd").ToString("MM/dd/yyyy");
                            DescriptionLbl.Text = reader.GetString("Description");
                            reader.Close();
                            using (MySqlCommand comd = new MySqlCommand(qry2, con))
                            {
                                comd.Parameters.AddWithValue("@taskId", TaskId);
                                MySqlDataReader reader2 = comd.ExecuteReader();
                                while (reader2.Read())
                                {
                                    string assignees = GetAssigneesName(reader2.GetInt32("UserId"));
                                    MembersText.Text = MembersText.Text + assignees + ", ";
                                }
                                reader2.Close();
                            }
                            using (MySqlCommand command = new MySqlCommand(qry3, con))
                            {
                                command.Parameters.AddWithValue("@taskId", TaskId);
                                MySqlDataReader reader3 = command.ExecuteReader();
                                while (reader3.Read())
                                {
                                    CommentCard card = new CommentCard();
                                    card.Comment.Text = reader3.GetString("CommentText");
                                    card.Uploader.Text = reader3.GetString("Uploader") + ", at " + reader3.GetDateTime("UploadDate");
                                    CommentsBox.Controls.Add(card);
                                }
                                reader3.Close();
                            }
                        }
                        
                        else
                        {
                            MessageBox.Show("Can't Find the Task");
                        }
                    }
                    con.Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message);
            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MessageText.Text) || MessageText.Text != "")
            {
                DateTime datetime = DateTime.Now;
                using (MySqlConnection con = new MySqlConnection(auth.constring))
                {
                    con.Open();
                    string qry = "INSERT INTO `comments`(`CommentText`, `TaskId`, `Uploader`, `UploadDate`) VALUES (?,?,?,?)";
                    using (MySqlCommand cmd  = new MySqlCommand(qry, con))
                    {
                        cmd.Parameters.AddWithValue("param1", MessageText.Text);
                        cmd.Parameters.AddWithValue("param2", TaskId);
                        cmd.Parameters.AddWithValue("param3", Username);
                        cmd.Parameters.AddWithValue("param4", datetime);
                        int insert = cmd.ExecuteNonQuery();
                        if (insert > 0)
                        {
                            CommentCard card = new CommentCard();
                            card.Comment.Text = MessageText.Text;
                            card.Uploader.Text = Username + ", at " + datetime;
                            CommentsBox.Controls.Add(card);
                            MessageText.Text = "";
                        }
                    }
                }
                
            }
        }
    }
}
