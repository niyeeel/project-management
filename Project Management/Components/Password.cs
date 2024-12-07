using System;
using System.Windows.Forms;

namespace Project_Management
{
    public partial class Password : UserControl
    {
        public Password()
        {
            InitializeComponent();
        }

        public void eye_CheckedChanged(object sender, EventArgs e)
        {
            Txt.PasswordChar = (eye.Checked) ? '●' : '\0';
        }
    }
}
