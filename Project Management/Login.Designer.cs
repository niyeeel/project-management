namespace Project_Management
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new Guna.UI2.WinForms.Guna2ImageButton();
            this.minimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.LoginBtn = new Project_Management.Btn();
            this.Password = new Project_Management.Password();
            this.usernameTxt = new Project_Management.Username();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 39);
            this.panel1.TabIndex = 9;
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
            this.close.Click += new System.EventHandler(this.close_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(51, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(51, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "LOG IN";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(146, 294);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign Up";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Doesn\'t have an account?";
            // 
            // LoginBtn
            // 
            this.LoginBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.LoginBtn.BorderColor = System.Drawing.Color.Empty;
            this.LoginBtn.BorderThickness = 0;
            this.LoginBtn.Dimentions = new System.Drawing.Size(187, 52);
            this.LoginBtn.Location = new System.Drawing.Point(90, 228);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(187, 52);
            this.LoginBtn.TabIndex = 18;
            this.LoginBtn.TextColor = System.Drawing.Color.White;
            this.LoginBtn.TextValue = "Log In";
            this.LoginBtn.Load += new System.EventHandler(this.btn1_Load);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Location = new System.Drawing.Point(43, 168);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(292, 32);
            this.Password.TabIndex = 17;
            this.Password.Load += new System.EventHandler(this.Password_Load);
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.Color.Transparent;
            this.usernameTxt.Location = new System.Drawing.Point(43, 109);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.PlaceHolder = null;
            this.usernameTxt.Size = new System.Drawing.Size(292, 35);
            this.usernameTxt.TabIndex = 15;
            this.usernameTxt.Load += new System.EventHandler(this.usernameTxt_Load);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 316);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton close;
        public Guna.UI2.WinForms.Guna2ImageButton minimize;
        private Password Password;
        private System.Windows.Forms.Label label4;
        private Username usernameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Btn LoginBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
    }
}