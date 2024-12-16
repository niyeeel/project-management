namespace Project_Management
{
    partial class AddNewMember
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
            this.PanelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Role = new System.Windows.Forms.Label();
            this.UserLTR = new Project_Management.Components.UserCircle();
            this.Username = new System.Windows.Forms.Label();
            this.NewMemberList = new System.Windows.Forms.FlowLayoutPanel();
            this.addBtn1 = new Project_Management.AddBtn();
            this.btn1 = new Project_Management.Btn();
            this.btn2 = new Project_Management.Btn();
            this.MembersList = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelContent.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // PanelContent
            // 
            this.PanelContent.AutoScroll = true;
            this.PanelContent.Controls.Add(this.guna2Panel1);
            this.PanelContent.Controls.Add(this.MembersList);
            this.PanelContent.Controls.Add(this.NewMemberList);
            this.PanelContent.Controls.Add(this.addBtn1);
            this.PanelContent.Location = new System.Drawing.Point(12, 12);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(625, 134);
            this.PanelContent.TabIndex = 25;
            this.PanelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContent_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.Role);
            this.guna2Panel1.Controls.Add(this.UserLTR);
            this.guna2Panel1.Controls.Add(this.Username);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(600, 40);
            this.guna2Panel1.TabIndex = 26;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role.Location = new System.Drawing.Point(473, 11);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(124, 20);
            this.Role.TabIndex = 23;
            this.Role.Text = "Project Manager";
            // 
            // UserLTR
            // 
            this.UserLTR.BackColor = System.Drawing.Color.Transparent;
            this.UserLTR.Location = new System.Drawing.Point(11, 5);
            this.UserLTR.Name = "UserLTR";
            this.UserLTR.Size = new System.Drawing.Size(26, 26);
            this.UserLTR.TabIndex = 22;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(43, 7);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(89, 21);
            this.Username.TabIndex = 21;
            this.Username.Text = "(User) You";
            // 
            // NewMemberList
            // 
            this.NewMemberList.AutoScroll = true;
            this.NewMemberList.Location = new System.Drawing.Point(3, 66);
            this.NewMemberList.Name = "NewMemberList";
            this.NewMemberList.Size = new System.Drawing.Size(600, 11);
            this.NewMemberList.TabIndex = 28;
            // 
            // addBtn1
            // 
            this.addBtn1.BackColor = System.Drawing.Color.Transparent;
            this.addBtn1.Location = new System.Drawing.Point(3, 83);
            this.addBtn1.Name = "addBtn1";
            this.addBtn1.Size = new System.Drawing.Size(25, 25);
            this.addBtn1.TabIndex = 22;
            this.addBtn1.Load += new System.EventHandler(this.addBtn1_Load);
            // 
            // btn1
            // 
            this.btn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.btn1.BorderColor = System.Drawing.Color.Black;
            this.btn1.BorderThickness = 2;
            this.btn1.Dimentions = new System.Drawing.Size(183, 45);
            this.btn1.Location = new System.Drawing.Point(62, 407);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(183, 45);
            this.btn1.TabIndex = 26;
            this.btn1.TextColor = System.Drawing.Color.White;
            this.btn1.TextValue = "Close";
            this.btn1.Load += new System.EventHandler(this.btn1_Load);
            // 
            // btn2
            // 
            this.btn2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.btn2.BorderColor = System.Drawing.Color.Empty;
            this.btn2.BorderThickness = 0;
            this.btn2.Dimentions = new System.Drawing.Size(180, 45);
            this.btn2.Location = new System.Drawing.Point(367, 407);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(180, 45);
            this.btn2.TabIndex = 27;
            this.btn2.TextColor = System.Drawing.Color.White;
            this.btn2.TextValue = "Save";
            this.btn2.Load += new System.EventHandler(this.btn2_Load);
            // 
            // MembersList
            // 
            this.MembersList.AutoScroll = true;
            this.MembersList.Location = new System.Drawing.Point(3, 49);
            this.MembersList.Name = "MembersList";
            this.MembersList.Size = new System.Drawing.Size(600, 11);
            this.MembersList.TabIndex = 29;
            // 
            // AddNewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 481);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.PanelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewMember";
            this.Text = "AddNewMember";
            this.Load += new System.EventHandler(this.AddNewMember_Load);
            this.PanelContent.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Btn btn2;
        private Btn btn1;
        public System.Windows.Forms.FlowLayoutPanel PanelContent;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.Label Role;
        public Components.UserCircle UserLTR;
        public System.Windows.Forms.Label Username;
        private AddBtn addBtn1;
        public System.Windows.Forms.FlowLayoutPanel NewMemberList;
        public System.Windows.Forms.FlowLayoutPanel MembersList;
    }
}