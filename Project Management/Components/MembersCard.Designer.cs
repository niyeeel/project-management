namespace Project_Management.Components
{
    partial class MembersCard
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
            this.Username = new System.Windows.Forms.Label();
            this.Role = new Guna.UI2.WinForms.Guna2ComboBox();
            this.UserLTR = new Project_Management.Components.UserCircle();
            this.MinusBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(43, 8);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(89, 21);
            this.Username.TabIndex = 18;
            this.Username.Text = "(User) You";
            // 
            // Role
            // 
            this.Role.BackColor = System.Drawing.Color.Transparent;
            this.Role.BorderColor = System.Drawing.Color.Black;
            this.Role.BorderRadius = 5;
            this.Role.BorderThickness = 2;
            this.Role.DisplayMember = "1";
            this.Role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Role.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Role.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Role.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Role.ItemHeight = 30;
            this.Role.Items.AddRange(new object[] {
            "Assistant",
            "UI/UX Designer",
            "Frontend Developer",
            "Backend Developer",
            "Graphics Designer",
            "System Analyst",
            "Secretary",
            "Producer",
            "Auditor",
            "Researcher",
            "Professor",
            "Member"});
            this.Role.Location = new System.Drawing.Point(360, 3);
            this.Role.MaxDropDownItems = 5;
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(172, 36);
            this.Role.StartIndex = 0;
            this.Role.TabIndex = 20;
            // 
            // UserLTR
            // 
            this.UserLTR.BackColor = System.Drawing.Color.Transparent;
            this.UserLTR.Location = new System.Drawing.Point(11, 6);
            this.UserLTR.Name = "UserLTR";
            this.UserLTR.Size = new System.Drawing.Size(26, 26);
            this.UserLTR.TabIndex = 19;
            // 
            // MinusBtn
            // 
            this.MinusBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.MinusBtn.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.MinusBtn.Image = global::Project_Management.Properties.Resources.minus;
            this.MinusBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.MinusBtn.ImageRotate = 0F;
            this.MinusBtn.Location = new System.Drawing.Point(557, 16);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.MinusBtn.Size = new System.Drawing.Size(30, 8);
            this.MinusBtn.TabIndex = 22;
            // 
            // MembersCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.UserLTR);
            this.Controls.Add(this.Username);
            this.Name = "MembersCard";
            this.Size = new System.Drawing.Size(600, 40);
            this.Load += new System.EventHandler(this.MembersCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Username;
        public UserCircle UserLTR;
        public Guna.UI2.WinForms.Guna2ComboBox Role;
        public Guna.UI2.WinForms.Guna2ImageButton MinusBtn;
    }
}
