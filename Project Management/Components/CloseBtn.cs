using System;
using System.Windows.Forms;

namespace Project_Management
{
    public partial class CloseBtn : UserControl
    {
        public CloseBtn()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
