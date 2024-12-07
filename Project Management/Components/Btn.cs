using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Management
{
    public partial class Btn : UserControl
    {
        Auth auth = new Auth();
        private void Msg(string msg, string title)
        {
            MessageBox.Show(msg, title);
        }
        public int GetUserID(string username)
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
                            int id = reader.GetInt32("Id");
                            conn.Close();
                            return id;
                        }
                        else
                        {
                            Msg("User Can't Found", "Error");
                            conn.Close();
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Msg("An Error Occured: " + ex.Message, "Error");
                return 0;
            }
        }
        public Btn()
        {
            InitializeComponent();
        }
        private string TxtVal;
        public string TextValue
        {
            get { return TxtVal; }
            set
            {
                TxtVal = value;
                main.Text = TxtVal;
            }
        }

        private Color BgClr;
        public Color BgColor
        {
            get { return BgClr = Color.FromArgb(0, 69, 129); }
            set
            {
                BgClr = value;
                main.FillColor = BgClr;
            }
        }
        private Color TxtClr;
        public Color TextColor
        {
            get { return TxtClr = Color.White; }
            set
            {
                TxtClr = value;
                main.ForeColor = TxtClr;
            }
        }
        private Color BorderClr;
        public Color BorderColor
        {
            get { return BorderClr; }
            set
            {
                BorderClr = value;
                main.BorderColor = BorderClr;
            }
        }

        private int BorderThick;
        public int BorderThickness
        {
            get { return BorderThick; }
            set
            {
                BorderThick = value;
                main.BorderThickness = BorderThick;
            }
        }
        private Size Dim;
        public Size Dimentions
        {
            get { return Dim = this.Size; }
            set
            {
                Dim = value;
                main.Size = Dim;
            }
        }
        public bool SignedUp(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(auth.constring))
            {
                try
                {
                    conn.Open();
                    string qry = "INSERT INTO `users`(`Username`, `Password`) VALUES (?,?)";
                    using (MySqlCommand cmd = new MySqlCommand(qry, conn))
                    {
                        cmd.Parameters.AddWithValue("param1", username);
                        cmd.Parameters.AddWithValue("param2", password);

                        cmd.ExecuteNonQuery();

                        Msg("Signed up successfully", "Welcome");
                        conn.Close();
                        return true;
                    }
                }
                catch (MySqlException ex)
                {
                    Msg("An Error occured: " + ex.Message, "Error");
                    conn.Close();
                    return false;
                }
            }
        }
        public void AssignMembers(int ProjectId, int userID, string Role)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(auth.constring))
                {
                    conn.Open();
                    string qry = "INSERT INTO `projectmembers`(`ProjectId`, `UserId`, `Role`) VALUES (?, ?, ?)";
                    using (MySqlCommand cmd = new MySqlCommand(qry, conn))
                    {
                        cmd.Parameters.AddWithValue("param1", ProjectId);
                        cmd.Parameters.AddWithValue("param2", userID);
                        cmd.Parameters.AddWithValue("param3", Role);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Msg("An Error occured: " + ex.Message, "Error");
            }
        }

        private void main_Click(object sender, EventArgs e)
        {

        }
    }
}