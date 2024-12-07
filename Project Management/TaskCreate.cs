using Microsoft.VisualBasic;
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
using Guna.UI2.WinForms;
using Project_Management.Components;

namespace Project_Management
{
    public partial class TaskCreate : Form
    {
        Auth auth = new Auth();
        int ProjId;
        string ProjectName;
        int UserId;
        FlowLayoutPanel panel;
        string status;
        TaskBoard Board;
        public TaskCreate(int ProjectId, string ProjectName, int userid, FlowLayoutPanel panel, string stats, TaskBoard board)
        {
            InitializeComponent();
            this.ProjId = ProjectId;
            this.ProjectName = ProjectName;
            this.UserId = userid;
            this.panel = panel;
            this.status = stats;
            this.Board = board;
        }

        private void TaskCreate_Load(object sender, EventArgs e)
        {

        }
        public void MinusBtn_Click(object sender, EventArgs e)
        {
            Guna2ImageButton Btn = (Guna2ImageButton)sender;
            if (Btn.Parent is AssignedCard)
            {
                AssignedCard parent = (AssignedCard)Btn.Parent;
                if (AssignedList.Controls.Contains(parent))
                {
                    AssignedList.Controls.Remove(parent);
                }
            }
        }

        private void btn1_Load(object sender, EventArgs e)
        {
            btn1.main.Click += Btn1_Click;
        }
        private bool ProperDueDate()
        {
            string[] duedates = DueDateBox.Text.Split('/');
            string[] startdates = TaskStart.Text.Split('/');
            for(int i = 0;i < 3; i++)
            {
                int Due = Convert.ToInt32(duedates[i]);
                int Start = Convert.ToInt32(startdates[i]);
                if (Due < Start)
                {
                    return true;
                }
            }
            return false;
        }
        public string formatDate(string date)
        {
            string[] dateSplit = date.Split('/');
            string year = dateSplit[2];
            string month = dateSplit[0];
            string day = dateSplit[1];
            string formattedDate = year + "-" + month + "-" + day;
            return formattedDate;
        }

        private int MemberCounter()
        {
            int Members = 0;
            foreach (AssignedCard members in AssignedList.Controls)
            {
                Members++;
            }
            return Members;
        }
        private int GetTaskId(string taskName)
        {
            using (MySqlConnection con = new MySqlConnection(auth.constring))
            {
                con.Open();
                string qry = "SELECT * FROM tasks WHERE ProjectId = @projId && TaskName = @name";
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@projId", ProjId);
                    cmd.Parameters.AddWithValue("@name", taskName);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader.GetInt32("id");
                    } else
                    {
                        return 0;
                    }
                }
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (TaskNameTxt.Text == null || TaskNameTxt.Text == "")
            {
                MessageBox.Show("Please Provide a Name of your Task!");
            } else if (TaskStart.Text == DueDateBox.Text || ProperDueDate()) {
                MessageBox.Show("Please Provide a proper task due date");
            } else
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(auth.constring))
                    {
                        con.Open();
                        string qry = "SELECT * FROM tasks WHERE TaskName = @name && ProjectId = @projId";
                        string qry2 = "INSERT INTO `tasks`(`ProjectId`, `TaskName`, `TaskStart`, `TaskEnd`, `Urgency`," +
                            " `Tags`, `Description`,`Status`, `CreatorId`, `NumberOfAssigned`) VALUES (?,?,?,?,?,?,?,?,?,?)";
                        string qry3 = "INSERT INTO taskmembers (UserId, TaskId) VALUES (?, ?)";
                        string qry4 = "UPDATE projects SET TasksNum = TasksNum + 1 WHERE ProjectId = @projID";
                        using (MySqlCommand comd = new MySqlCommand(qry, con))
                        {
                            comd.Parameters.AddWithValue("@name", TaskNameTxt.Text);
                            comd.Parameters.AddWithValue("@projId",ProjId);
                            MySqlDataReader reader = comd.ExecuteReader();
                            if (reader.Read())
                            {
                                MessageBox.Show("You Already Make This Task");
                            } else
                            {
                                reader.Close();
                                using (MySqlCommand cmd = new MySqlCommand(qry2, con))
                                {
                                    cmd.Parameters.AddWithValue("param1", ProjId);
                                    cmd.Parameters.AddWithValue("param2", TaskNameTxt.Text);
                                    cmd.Parameters.AddWithValue("param3", formatDate(TaskStart.Text));
                                    cmd.Parameters.AddWithValue("param4", formatDate(DueDateBox.Text));
                                    cmd.Parameters.AddWithValue("param5", Urgency.Text);
                                    cmd.Parameters.AddWithValue("param6", TagDown.Text);
                                    cmd.Parameters.AddWithValue("param7", DescTxt.Text);
                                    cmd.Parameters.AddWithValue("param8", status);
                                    cmd.Parameters.AddWithValue("param9", UserId);
                                    cmd.Parameters.AddWithValue("param10", MemberCounter());
                                    int insert = cmd.ExecuteNonQuery();
                                    if (insert > 0)
                                    {
                                        int taskId = GetTaskId(TaskNameTxt.Text);
                                        if (taskId > 0)
                                        {
                                            foreach (AssignedCard assignees in AssignedList.Controls)
                                            {
                                                using (MySqlCommand cm = new MySqlCommand(qry3, con))
                                                {
                                                    cm.Parameters.AddWithValue("param1", btn1.GetUserID(assignees.Username.Text));
                                                    cm.Parameters.AddWithValue("param2", taskId);
                                                    cm.ExecuteNonQuery();
                                                }
                                            }
                                            using (MySqlCommand cmd2 = new MySqlCommand(qry4, con))
                                            {
                                                cmd2.Parameters.AddWithValue("@projID", ProjId);
                                                cmd2.ExecuteNonQuery();
                                            }
                                            TaskCard card = new TaskCard();
                                            card.TaskNameLbl.Text = TaskNameTxt.Text;
                                            int NumofAssign = MemberCounter();
                                            card.MembersLbl.Text = Convert.ToString(NumofAssign);
                                            card.DueLbl.Text = DueDateBox.Text;
                                            card.Click += (s, args) =>
                                            {
                                                Board.TaskClick(taskId);
                                            };
                                            panel.Controls.Add(card);
                                            MessageBox.Show("Task Successfully Added");
                                            con.Close();
                                            this.Close();
                                        } else
                                        {
                                            MessageBox.Show("Task Creation Failed");
                                        }
                                        
                                    }
                                }
                            }
                        }
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Error occured: " + ex.Message);
                }
            }
        }

        private void addBtn1_Load(object sender, EventArgs e)
        {
            addBtn1.Btn.Click += AddBtn1_Click;
        }

        private void AddBtn1_Click(object sender, EventArgs e)
        {
            AssignForm assign = new AssignForm(this, ProjId);
            assign.ShowDialog();
        }
    }
}