namespace Project_Management
{
    partial class TaskBoard
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
            this.ProjectName = new System.Windows.Forms.Label();
            this.panelToDo = new System.Windows.Forms.FlowLayoutPanel();
            this.panelInProgress = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCompleted = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addBtn2 = new Project_Management.AddBtn();
            this.addBtn1 = new Project_Management.AddBtn();
            this.nav1 = new Project_Management.nav();
            this.BackBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.AddNewMemberBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSize = true;
            this.ProjectName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectName.Location = new System.Drawing.Point(44, 114);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(180, 37);
            this.ProjectName.TabIndex = 1;
            this.ProjectName.Text = "projectname";
            // 
            // panelToDo
            // 
            this.panelToDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelToDo.Location = new System.Drawing.Point(51, 209);
            this.panelToDo.Name = "panelToDo";
            this.panelToDo.Size = new System.Drawing.Size(307, 414);
            this.panelToDo.TabIndex = 4;
            // 
            // panelInProgress
            // 
            this.panelInProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInProgress.Location = new System.Drawing.Point(364, 209);
            this.panelInProgress.Name = "panelInProgress";
            this.panelInProgress.Size = new System.Drawing.Size(307, 414);
            this.panelInProgress.TabIndex = 5;
            // 
            // panelCompleted
            // 
            this.panelCompleted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCompleted.Location = new System.Drawing.Point(677, 209);
            this.panelCompleted.Name = "panelCompleted";
            this.panelCompleted.Size = new System.Drawing.Size(307, 414);
            this.panelCompleted.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "To-Do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "In Progress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(673, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Completed";
            // 
            // addBtn2
            // 
            this.addBtn2.BackColor = System.Drawing.Color.Transparent;
            this.addBtn2.Location = new System.Drawing.Point(460, 181);
            this.addBtn2.Name = "addBtn2";
            this.addBtn2.Size = new System.Drawing.Size(25, 25);
            this.addBtn2.TabIndex = 10;
            this.addBtn2.Load += new System.EventHandler(this.addBtn2_Load);
            // 
            // addBtn1
            // 
            this.addBtn1.BackColor = System.Drawing.Color.Transparent;
            this.addBtn1.Location = new System.Drawing.Point(109, 181);
            this.addBtn1.Name = "addBtn1";
            this.addBtn1.Size = new System.Drawing.Size(25, 25);
            this.addBtn1.TabIndex = 9;
            this.addBtn1.Load += new System.EventHandler(this.addBtn1_Load);
            // 
            // nav1
            // 
            this.nav1.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav1.Location = new System.Drawing.Point(0, 0);
            this.nav1.Name = "nav1";
            this.nav1.Size = new System.Drawing.Size(1060, 50);
            this.nav1.TabIndex = 0;
            // 
            // BackBtn
            // 
            this.BackBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BackBtn.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.BackBtn.Image = global::Project_Management.Properties.Resources.back;
            this.BackBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.BackBtn.ImageRotate = 0F;
            this.BackBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.BackBtn.Location = new System.Drawing.Point(22, 56);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.BackBtn.Size = new System.Drawing.Size(30, 30);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AddNewMemberBtn
            // 
            this.AddNewMemberBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.AddNewMemberBtn.HoverState.ImageSize = new System.Drawing.Size(52, 52);
            this.AddNewMemberBtn.Image = global::Project_Management.Properties.Resources.addmember;
            this.AddNewMemberBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.AddNewMemberBtn.ImageRotate = 0F;
            this.AddNewMemberBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.AddNewMemberBtn.Location = new System.Drawing.Point(875, 56);
            this.AddNewMemberBtn.Name = "AddNewMemberBtn";
            this.AddNewMemberBtn.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.AddNewMemberBtn.Size = new System.Drawing.Size(50, 50);
            this.AddNewMemberBtn.TabIndex = 11;
            this.AddNewMemberBtn.Click += new System.EventHandler(this.AddNewMemberBtn_Click);
            // 
            // TaskBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 720);
            this.Controls.Add(this.AddNewMemberBtn);
            this.Controls.Add(this.addBtn2);
            this.Controls.Add(this.addBtn1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelCompleted);
            this.Controls.Add(this.panelInProgress);
            this.Controls.Add(this.panelToDo);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.nav1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskBoard";
            this.Load += new System.EventHandler(this.TaskBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private nav nav1;
        private Guna.UI2.WinForms.Guna2ImageButton BackBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private AddBtn addBtn2;
        private AddBtn addBtn1;
        public System.Windows.Forms.Label ProjectName;
        public System.Windows.Forms.FlowLayoutPanel panelCompleted;
        public System.Windows.Forms.FlowLayoutPanel panelInProgress;
        public System.Windows.Forms.FlowLayoutPanel panelToDo;
        private Guna.UI2.WinForms.Guna2ImageButton AddNewMemberBtn;
    }
}