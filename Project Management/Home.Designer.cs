using System.Runtime.InteropServices;

namespace Project_Management
{
    partial class Home
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
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.LinkLabel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn1 = new Project_Management.Btn();
            this.ProjectsDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gdfg = new System.Windows.Forms.Label();
            this.ProjectLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TasksLbl = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.DoneLbl = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.nav1 = new Project_Management.nav();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ContentPanel.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.flowPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.LogoutBtn);
            this.ContentPanel.Controls.Add(this.guna2Panel4);
            this.ContentPanel.Controls.Add(this.flowPanel);
            this.ContentPanel.Controls.Add(this.label);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 50);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1060, 670);
            this.ContentPanel.TabIndex = 2;
            this.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPanel_Paint);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.AutoSize = true;
            this.LogoutBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.Black;
            this.LogoutBtn.LinkColor = System.Drawing.Color.Black;
            this.LogoutBtn.Location = new System.Drawing.Point(992, 42);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(51, 17);
            this.LogoutBtn.TabIndex = 4;
            this.LogoutBtn.TabStop = true;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutBtn_LinkClicked);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.btn1);
            this.guna2Panel4.Controls.Add(this.ProjectsDisplay);
            this.guna2Panel4.Controls.Add(this.label1);
            this.guna2Panel4.Location = new System.Drawing.Point(10, 236);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(1035, 407);
            this.guna2Panel4.TabIndex = 3;
            this.guna2Panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel4_Paint);
            // 
            // btn1
            // 
            this.btn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.btn1.BorderColor = System.Drawing.Color.Empty;
            this.btn1.BorderThickness = 0;
            this.btn1.Dimentions = new System.Drawing.Size(180, 45);
            this.btn1.Location = new System.Drawing.Point(830, 30);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(180, 45);
            this.btn1.TabIndex = 2;
            this.btn1.TextColor = System.Drawing.Color.White;
            this.btn1.TextValue = "Add Project";
            this.btn1.Load += new System.EventHandler(this.btn1_Load);
            // 
            // ProjectsDisplay
            // 
            this.ProjectsDisplay.AutoScroll = true;
            this.ProjectsDisplay.Location = new System.Drawing.Point(19, 81);
            this.ProjectsDisplay.Name = "ProjectsDisplay";
            this.ProjectsDisplay.Size = new System.Drawing.Size(991, 303);
            this.ProjectsDisplay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projects";
            // 
            // flowPanel
            // 
            this.flowPanel.AutoSize = true;
            this.flowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowPanel.Controls.Add(this.guna2Panel1);
            this.flowPanel.Controls.Add(this.guna2Panel2);
            this.flowPanel.Controls.Add(this.guna2Panel3);
            this.flowPanel.Location = new System.Drawing.Point(10, 76);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(1041, 154);
            this.flowPanel.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.gdfg);
            this.guna2Panel1.Controls.Add(this.ProjectLbl);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(341, 148);
            this.guna2Panel1.TabIndex = 0;
            // 
            // gdfg
            // 
            this.gdfg.AutoSize = true;
            this.gdfg.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdfg.Location = new System.Drawing.Point(88, 24);
            this.gdfg.Name = "gdfg";
            this.gdfg.Size = new System.Drawing.Size(131, 25);
            this.gdfg.TabIndex = 0;
            this.gdfg.Text = "Total Projects";
            // 
            // ProjectLbl
            // 
            this.ProjectLbl.AutoSize = true;
            this.ProjectLbl.BackColor = System.Drawing.Color.Transparent;
            this.ProjectLbl.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectLbl.Location = new System.Drawing.Point(144, 63);
            this.ProjectLbl.Name = "ProjectLbl";
            this.ProjectLbl.Size = new System.Drawing.Size(56, 65);
            this.ProjectLbl.TabIndex = 1;
            this.ProjectLbl.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Management.Properties.Resources.Pending__arcade_;
            this.pictureBox1.Location = new System.Drawing.Point(21, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.TasksLbl);
            this.guna2Panel2.Controls.Add(this.pictureBox4);
            this.guna2Panel2.Location = new System.Drawing.Point(350, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(341, 148);
            this.guna2Panel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tasks to do";
            // 
            // TasksLbl
            // 
            this.TasksLbl.AutoSize = true;
            this.TasksLbl.BackColor = System.Drawing.Color.Transparent;
            this.TasksLbl.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksLbl.Location = new System.Drawing.Point(151, 63);
            this.TasksLbl.Name = "TasksLbl";
            this.TasksLbl.Size = new System.Drawing.Size(56, 65);
            this.TasksLbl.TabIndex = 1;
            this.TasksLbl.Text = "0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Project_Management.Properties.Resources.Tasks;
            this.pictureBox4.Location = new System.Drawing.Point(21, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel3.BorderRadius = 10;
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.label8);
            this.guna2Panel3.Controls.Add(this.DoneLbl);
            this.guna2Panel3.Controls.Add(this.pictureBox5);
            this.guna2Panel3.Location = new System.Drawing.Point(697, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(341, 148);
            this.guna2Panel3.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(90, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tasks Completed";
            // 
            // DoneLbl
            // 
            this.DoneLbl.AutoSize = true;
            this.DoneLbl.BackColor = System.Drawing.Color.Transparent;
            this.DoneLbl.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneLbl.Location = new System.Drawing.Point(143, 63);
            this.DoneLbl.Name = "DoneLbl";
            this.DoneLbl.Size = new System.Drawing.Size(56, 65);
            this.DoneLbl.TabIndex = 1;
            this.DoneLbl.Text = "0";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Project_Management.Properties.Resources.Check__arcade_;
            this.pictureBox5.Location = new System.Drawing.Point(21, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 57);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(27, 21);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(105, 40);
            this.label.TabIndex = 1;
            this.label.Text = "Hello, ";
            // 
            // nav1
            // 
            this.nav1.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav1.Location = new System.Drawing.Point(0, 0);
            this.nav1.Name = "nav1";
            this.nav1.Size = new System.Drawing.Size(1060, 50);
            this.nav1.TabIndex = 0;
            this.nav1.Load += new System.EventHandler(this.nav1_Load);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.nav1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1060, 720);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.nav1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.flowPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private nav nav1;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label gdfg;
        public System.Windows.Forms.Label ProjectLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label TasksLbl;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label DoneLbl;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        public System.Windows.Forms.FlowLayoutPanel ProjectsDisplay;
        private System.Windows.Forms.Label label1;
        private Btn btn1;
        private System.Windows.Forms.LinkLabel LogoutBtn;
    }
}