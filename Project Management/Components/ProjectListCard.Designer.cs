namespace Project_Management
{
    partial class ProjectListCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectListCard));
            this.label2 = new System.Windows.Forms.Label();
            this.MemberNum = new System.Windows.Forms.Label();
            this.TaskNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DescLbl = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ProjectName = new System.Windows.Forms.LinkLabel();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(834, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Members";
            // 
            // MemberNum
            // 
            this.MemberNum.AutoSize = true;
            this.MemberNum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNum.Location = new System.Drawing.Point(800, 78);
            this.MemberNum.Name = "MemberNum";
            this.MemberNum.Size = new System.Drawing.Size(27, 32);
            this.MemberNum.TabIndex = 2;
            this.MemberNum.Text = "0";
            // 
            // TaskNum
            // 
            this.TaskNum.AutoSize = true;
            this.TaskNum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNum.Location = new System.Drawing.Point(800, 17);
            this.TaskNum.Name = "TaskNum";
            this.TaskNum.Size = new System.Drawing.Size(27, 32);
            this.TaskNum.TabIndex = 4;
            this.TaskNum.Text = "0";
            this.TaskNum.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(834, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tasks";
            // 
            // DescLbl
            // 
            this.DescLbl.AutoEllipsis = true;
            this.DescLbl.Location = new System.Drawing.Point(20, 78);
            this.DescLbl.Name = "DescLbl";
            this.DescLbl.Size = new System.Drawing.Size(671, 32);
            this.DescLbl.TabIndex = 6;
            this.DescLbl.Text = resources.GetString("DescLbl.Text");
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.ProjectName);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 3;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(950, 120);
            this.guna2ShadowPanel1.TabIndex = 7;
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSize = true;
            this.ProjectName.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.ProjectName.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ProjectName.LinkColor = System.Drawing.Color.Black;
            this.ProjectName.Location = new System.Drawing.Point(20, 17);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(157, 40);
            this.ProjectName.TabIndex = 0;
            this.ProjectName.TabStop = true;
            this.ProjectName.Text = "linkLabel1";
            // 
            // ProjectListCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DescLbl);
            this.Controls.Add(this.TaskNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MemberNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "ProjectListCard";
            this.Size = new System.Drawing.Size(950, 120);
            this.Load += new System.EventHandler(this.ProjectListCard_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label MemberNum;
        public System.Windows.Forms.Label TaskNum;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label DescLbl;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        public System.Windows.Forms.LinkLabel ProjectName;
    }
}
