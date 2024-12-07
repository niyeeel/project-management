namespace Project_Management
{
    partial class Password
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.eye = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.SuspendLayout();
            // 
            // Txt
            // 
            this.Txt.BorderRadius = 5;
            this.Txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt.DefaultText = "";
            this.Txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt.ForeColor = System.Drawing.Color.Black;
            this.Txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt.IconLeft = global::Project_Management.Properties.Resources.password;
            this.Txt.Location = new System.Drawing.Point(1, 1);
            this.Txt.Name = "Txt";
            this.Txt.Padding = new System.Windows.Forms.Padding(5, 3, 50, 3);
            this.Txt.PasswordChar = '●';
            this.Txt.PlaceholderText = "Password";
            this.Txt.SelectedText = "";
            this.Txt.Size = new System.Drawing.Size(290, 30);
            this.Txt.TabIndex = 1;
            // 
            // eye
            // 
            this.eye.BackColor = System.Drawing.Color.White;
            this.eye.Checked = true;
            this.eye.CheckedState.Image = global::Project_Management.Properties.Resources.eye_closed;
            this.eye.Image = global::Project_Management.Properties.Resources.eye;
            this.eye.ImageOffset = new System.Drawing.Point(0, 0);
            this.eye.ImageRotate = 0F;
            this.eye.Location = new System.Drawing.Point(265, 4);
            this.eye.Name = "eye";
            this.eye.Size = new System.Drawing.Size(24, 24);
            this.eye.TabIndex = 2;
            this.eye.CheckedChanged += new System.EventHandler(this.eye_CheckedChanged);
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.eye);
            this.Controls.Add(this.Txt);
            this.Name = "Password";
            this.Size = new System.Drawing.Size(292, 32);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox Txt;
        public Guna.UI2.WinForms.Guna2ImageCheckBox eye;
    }
}
