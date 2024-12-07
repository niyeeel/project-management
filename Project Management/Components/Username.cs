using System;
using System.Windows.Forms;

namespace Project_Management
{
    public partial class Username : UserControl
    {
        private string placeholder;
        public string PlaceHolder
        {
            get { return placeholder; }
            set { placeholder = value; Txt.PlaceholderText = placeholder; }
        }
        public Username()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
