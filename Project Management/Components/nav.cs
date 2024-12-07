using System;
using System.Windows.Forms;

namespace Project_Management
{
    public partial class nav : UserControl
    {
        public Form form = new Form();
        public nav()
        {
            InitializeComponent();
        }

        private void nav_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            form.WindowState = FormWindowState.Minimized;
        }
    }
}
