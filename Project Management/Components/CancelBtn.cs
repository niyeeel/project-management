using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management.Components
{
    public partial class CancelBtn : UserControl
    {
        public CancelBtn()
        {
            InitializeComponent();
        }

        private void main_Click(object sender, EventArgs e)
        {
            Form mainForm = this.Parent as Form;
            mainForm.Close();
        }
    }
}
