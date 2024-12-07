using System;
using System.Windows.Forms;

namespace Project_Management
{
    public partial class MinimizeBtn : UserControl
    {
        private Form form { get; set; }
        public Form TargetForm
        {
            get { return TargetForm; }
            set
            {
                TargetForm = value;
                form = TargetForm;
            }
        }
        public MinimizeBtn()
        {
            InitializeComponent();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            form.WindowState = FormWindowState.Minimized;
        }
    }
}
