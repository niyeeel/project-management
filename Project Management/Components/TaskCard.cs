using System;
using System.Windows.Forms;

namespace Project_Management
{
    public partial class TaskCard : UserControl
    {
        public TaskCard()
        {
            InitializeComponent();
            this.MouseDown += TaskCard_MouseDown;
        }

        private void TaskCard_Load(object sender, EventArgs e)
        {

        }

        private void TaskCard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.DoDragDrop(this, DragDropEffects.Move);
            }
        }
    }
}
