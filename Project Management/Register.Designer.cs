namespace Project_Management
{
    partial class Register
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new Guna.UI2.WinForms.Guna2ImageButton();
            this.minimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.Con_password = new Project_Management.Password();
            this.Password = new Project_Management.Password();
            this.SignUp = new Project_Management.Btn();
            this.username1 = new Project_Management.Username();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "SIGN UP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(50, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(52, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm Password";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 39);
            this.panel1.TabIndex = 8;
            // 
            // close
            // 
            this.close.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.close.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.close.Image = global::Project_Management.Properties.Resources.Close__X_;
            this.close.ImageOffset = new System.Drawing.Point(0, 0);
            this.close.ImageRotate = 0F;
            this.close.ImageSize = new System.Drawing.Size(23, 23);
            this.close.Location = new System.Drawing.Point(332, 11);
            this.close.Name = "close";
            this.close.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 4;
            this.close.Click += new System.EventHandler(this.close_Click_1);
            // 
            // minimize
            // 
            this.minimize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.minimize.Image = global::Project_Management.Properties.Resources.minimize;
            this.minimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.minimize.ImageRotate = 0F;
            this.minimize.Location = new System.Drawing.Point(295, 19);
            this.minimize.Name = "minimize";
            this.minimize.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.minimize.Size = new System.Drawing.Size(20, 5);
            this.minimize.TabIndex = 3;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(50, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // Con_password
            // 
            this.Con_password.BackColor = System.Drawing.Color.Transparent;
            this.Con_password.Location = new System.Drawing.Point(42, 217);
            this.Con_password.Name = "Con_password";
            this.Con_password.Size = new System.Drawing.Size(292, 32);
            this.Con_password.TabIndex = 13;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Location = new System.Drawing.Point(42, 158);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(292, 32);
            this.Password.TabIndex = 12;
            this.Password.Load += new System.EventHandler(this.password2_Load);
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.Transparent;
            this.SignUp.Location = new System.Drawing.Point(93, 275);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(187, 52);
            this.SignUp.TabIndex = 7;
            this.SignUp.TextValue = "Sign Up";
            this.SignUp.Load += new System.EventHandler(this.btn1_Load);
            // 
            // username1
            // 
            this.username1.BackColor = System.Drawing.Color.Transparent;
            this.username1.Location = new System.Drawing.Point(42, 99);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(292, 35);
            this.username1.TabIndex = 6;
            this.username1.Load += new System.EventHandler(this.username1_Load);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Already have an account?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(148, 371);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log In";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(380, 393);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Con_password);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.username1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Username username1;
        private Btn SignUp;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        public Guna.UI2.WinForms.Guna2ImageButton minimize;
        private Guna.UI2.WinForms.Guna2ImageButton close;
        private System.Windows.Forms.Label label4;
        private Password Password;
        private Password Con_password;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
    }
}