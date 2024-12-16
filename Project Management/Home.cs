using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Project_Management.Components;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_Management
{
    public partial class Home : Form
    {
        private readonly string user;
        Auth auth = new Auth();
        private readonly int userId;
        public Home(string username, int id)
        {
            InitializeComponent();
            this.user = username;
            this.userId = id;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(auth.constring))
                {
                    conn.Open();
                    int totalProject = 0;
                    string qry = "SELECT * FROM projects " +
                        "INNER JOIN projectmembers ON projects.ProjectId = projectmembers.ProjectId WHERE projectmembers.UserId = @userId";
                    using (MySqlCommand cmd = new MySqlCommand(qry, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            ProjectListCard card = new ProjectListCard();
                            card.ProjectName.Click += ProjectName_Click;
                            card.ProjectName.Text = reader.GetString("ProjectName");
                            card.DescLbl.Text = reader.GetString("ProjectDescription");
                            card.MemberNum.Text = reader.GetInt32("MemberNum").ToString();
                            card.TaskNum.Text = reader.GetInt32("TasksNum").ToString();
                            ProjectsDisplay.Controls.Add(card);
                            totalProject++;
                        }
                        reader.Close();
                    }
                    if (totalProject == 0)
                    {
                        ProjectsDisplay.Controls.Clear();
                        NoProject np = new NoProject();
                        ProjectsDisplay.AutoScroll = false;
                        ProjectsDisplay.Controls.Add(np);
                    }
                    label.Text = "Hello, " + user;
                    ProjectLbl.Text = totalProject.ToString();
                    TasksLbl.Text = CountAllTask("ToDo").ToString();
                    DoneLbl.Text = CountAllTask("Completed").ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Load Contents. Error: " + ex.Message, "Error");
            }
        }

        private int CountAllTask(string Status)
        {
            int TotalTask = 0;
            using (MySqlConnection con = new MySqlConnection(auth.constring))
            {
                con.Open();
                string qry = "SELECT * FROM projects " +
                    "INNER JOIN projectmembers ON projects.ProjectId = projectmembers.ProjectId " +
                    "INNER JOIN tasks ON tasks.ProjectId = projectmembers.ProjectId WHERE projectmembers.UserId = @userID";
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@userID", userId);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        if (reader.GetString("Status") == Status)
                        {
                            TotalTask++;
                        }
                    }
                    reader.Close();
                }
                con.Close();
            }
            return TotalTask;
        }

        private void ProjectName_Click(object sender, EventArgs e)
        {
            LinkLabel Project = (LinkLabel)sender;
            TaskBoard task = new TaskBoard(userId,user, GetProjectId(Project.Text, userId));
            task.ProjectName.Text = Project.Text;
            task.Show();
            this.Close();
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        public int GetProjectId(string ProjectName, int UserID)
        {
            using (MySqlConnection con = new MySqlConnection(auth.constring))
            {
                con.Open();
                string qry = "SELECT * FROM `projects` JOIN projectmembers ON projects.ProjectId = projectmembers.ProjectId WHERE ProjectName = @proj && projectmembers.UserId = @id";
                using (MySqlCommand comd = new MySqlCommand(qry, con))
                {
                    comd.Parameters.AddWithValue("@proj", ProjectName);
                    comd.Parameters.AddWithValue("@id", UserID);
                    MySqlDataReader reader = comd.ExecuteReader();
                    if (reader.Read())
                    {
                        int ProjId = reader.GetInt32("ProjectId");
                        return ProjId;
                    }
                    else
                    {
                        MessageBox.Show("Task Creation Failed", "Error");
                        con.Close();
                        return 0;
                    }
                }
            }
        }
        private int ProjectTaskCounter(string ProjName, int UserID)
        {
            int TaskNum = 0;
            using (MySqlConnection con = new MySqlConnection(auth.constring))
            {
                con.Open();
                string qry = "SELECT * FROM `tasks` " +
                    "INNER JOIN projectmembers ON projectmembers.ProjectId = tasks.ProjectId " +
                    "INNER JOIN projects ON projects.ProjectId = projectmembers.ProjectId WHERE projects.ProjectName = @projName && projectmembers.UserId = @userID";
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@projName", ProjName);
                    cmd.Parameters.AddWithValue("@userID", UserID);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TaskNum++;
                    }
                }
            }
            return TaskNum;
        }
        private void btn1_Load(object sender, EventArgs e)
        {
            btn1.main.Click += Main_Click;
        }

        private void Main_Click(object sender, EventArgs e)
        {
            CreateFirstProject create = new CreateFirstProject(user);
            create.NextBtn.Text = "Back";
            create.Show();
            this.Close();
        }

        private void LogoutBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void nav1_Load(object sender, EventArgs e)
        {

        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
