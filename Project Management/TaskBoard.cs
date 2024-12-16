using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Project_Management.Components;

namespace Project_Management
{
    public partial class TaskBoard : Form
    {
        private readonly int userId;
        private readonly string userName;
        private int projId;
        Auth auth = new Auth();
        public TaskBoard(int userid,string username, int projID)
        {
            InitializeComponent();
            this.userId = userid;
            this.userName = username;
            this.projId = projID;
        }

        private void TaskBoard_Load(object sender, EventArgs e)
        {
            panelToDo.AllowDrop = true;
            panelInProgress.AllowDrop = true;
            panelCompleted.AllowDrop = true;

            panelToDo.DragEnter += Panel_DragEnter;
            panelInProgress.DragEnter += Panel_DragEnter;
            panelCompleted.DragEnter += Panel_DragEnter;

            panelToDo.DragDrop += Panel_DragDrop;
            panelInProgress.DragDrop += Panel_DragDrop;
            panelCompleted.DragDrop += Panel_DragDrop;

            using (MySqlConnection con = new MySqlConnection(auth.constring))
            {
                con.Open();
                string qry = "SELECT * FROM `tasks` WHERE ProjectId = @projId";
                using (MySqlCommand comd = new MySqlCommand(qry, con))
                {
                    comd.Parameters.AddWithValue("@projId", projId);
                    MySqlDataReader reader = comd.ExecuteReader();
                    while (reader.Read())
                    {
                        TaskCard card = new TaskCard();
                        card.TaskNameLbl.Text = reader.GetString("TaskName");
                        card.DueLbl.Text = Convert.ToString(reader.GetDateTime("TaskEnd"));
                        card.MembersLbl.Text = Convert.ToString(reader.GetInt32("NumberOfAssigned"));
                        int taskId = reader.GetInt32("id");
                        card.TaskNameLbl.Click += (s, args) =>
                        {
                            TaskClick(taskId);
                        };
                        if (reader.GetString("Status") == "ToDo")
                        {
                            panelToDo.Controls.Add(card);
                        } else if (reader.GetString("Status") == "InProgress")
                        {
                            panelInProgress.Controls.Add(card);
                        } else if (reader.GetString("Status") == "Completed")
                        {
                            panelCompleted.Controls.Add(card);
                        }
                    }
                }
            }
        }

        public void TaskClick(int taskId)
        {
            TaskOverview taskP = new TaskOverview(taskId, userName);
            taskP.ShowDialog();
        }

        private void GetProjectTasks()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(auth.constring))
                {
                    string qry = "SELECT * FROM tasks INNER JOIN taskmembers ON tasks.id = " +
                        "taskmembers.TaskId WHERE taskmembers = @userId && ProjectId = @ProjectId";
                    using (MySqlCommand cmd = new MySqlCommand(qry, con))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@ProjectId", 1);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("An error occured: Error:" + ex.Message);
            }
        }

        private void Panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TaskCard)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private int GetTaskId(string taskName)
        {
            using (MySqlConnection con = new MySqlConnection(auth.constring))
            {
                con.Open();
                string qry = "SELECT * FROM tasks WHERE ProjectId = @projId && TaskName = @name";
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@projId", projId);
                    cmd.Parameters.AddWithValue("@name", taskName);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader.GetInt32("id");
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        private void Panel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TaskCard)))
            {
                var taskCard = (TaskCard)e.Data.GetData(typeof(TaskCard));
                var targetPanel = (Panel)sender;
                targetPanel.Controls.Add(taskCard);
                taskCard.Location = targetPanel.PointToClient(new Point(e.X, e.Y));
                string status = (targetPanel.Name == "panelToDo") ? "ToDo" : (targetPanel.Name == "panelInProgress") ? "InProgress" : "Completed";
                try
                {
                    using (MySqlConnection con = new MySqlConnection(auth.constring))
                    {
                        con.Open();
                        string qry = "UPDATE tasks SET Status = @status WHERE ProjectId = @projId && id = @ID";
                        using (MySqlCommand cmd = new MySqlCommand(qry, con))
                        {
                            cmd.Parameters.AddWithValue("@status", status);
                            cmd.Parameters.AddWithValue("@projId", projId);
                            cmd.Parameters.AddWithValue("@ID", GetTaskId(taskCard.TaskNameLbl.Text));
                            cmd.ExecuteNonQuery();
                        }
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void addBtn1_Load(object sender, EventArgs e)
        {
            addBtn1.Btn.Click += AddToDo;
        }

        private void AddToDo(object sender, EventArgs e)
        {
            TaskCreate task = new TaskCreate(projId, ProjectName.Text, userId, panelToDo, "ToDo", this);
            task.YouCard.Username.Text = userName;
            task.YouCard.UserLTR.Letter.Text = userName.Substring(0, 1).ToUpper();
            task.ShowDialog();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Home newHome = new Home(userName, userId);
            newHome.Show();
            this.Close();
        }

        private void addBtn2_Load(object sender, EventArgs e)
        {
            addBtn2.Btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            TaskCreate task = new TaskCreate(projId, ProjectName.Text, userId, panelInProgress, "InProgress", this);
            task.YouCard.Username.Text = userName;
            task.YouCard.UserLTR.Letter.Text = userName.Substring(0, 1).ToUpper();
            task.ShowDialog();
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            TaskCreate task = new TaskCreate(projId, ProjectName.Text, userId, panelCompleted, "Completed", this);
            task.YouCard.Username.Text = userName;
            task.YouCard.UserLTR.Letter.Text = userName.Substring(0, 1).ToUpper();
            task.ShowDialog();
        }

        private void AddNewMemberBtn_Click(object sender, EventArgs e)
        {
            AddNewMember addm = new AddNewMember(projId, userId, userName);
            addm.Show();
        }
    }
}
