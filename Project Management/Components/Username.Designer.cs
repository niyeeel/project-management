namespace Project_Management
{
    partial class Username
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
            this.Txt.IconLeft = global::Project_Management.Properties.Resources.user;
            this.Txt.Location = new System.Drawing.Point(1, 1);
            this.Txt.Name = "Txt";
            this.Txt.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Txt.PasswordChar = '\0';
            this.Txt.PlaceholderText = "Username";
            this.Txt.SelectedText = "";
            this.Txt.Size = new System.Drawing.Size(290, 30);
            this.Txt.TabIndex = 0;
            this.Txt.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // Username
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Txt);
            this.Name = "Username";
            this.Size = new System.Drawing.Size(292, 32);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox Txt;
    }
}
