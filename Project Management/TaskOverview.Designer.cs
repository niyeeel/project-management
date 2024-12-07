namespace Project_Management
{
    partial class TaskOverview
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
            this.taskName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgressLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MessageText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SendBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CommentsBox = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Urgency = new System.Windows.Forms.Label();
            this.TagLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.Label();
            this.DueDate = new System.Windows.Forms.Label();
            this.MembersText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // taskName
            // 
            this.taskName.AutoSize = true;
            this.taskName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskName.Location = new System.Drawing.Point(21, 9);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(72, 30);
            this.taskName.TabIndex = 2;
            this.taskName.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Progress: ";
            // 
            // ProgressLbl
            // 
            this.ProgressLbl.AutoSize = true;
            this.ProgressLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressLbl.Location = new System.Drawing.Point(111, 69);
            this.ProgressLbl.Name = "ProgressLbl";
            this.ProgressLbl.Size = new System.Drawing.Size(54, 21);
            this.ProgressLbl.TabIndex = 4;
            this.ProgressLbl.Text = "To-Do";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoEllipsis = true;
            this.DescriptionLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLbl.Location = new System.Drawing.Point(27, 262);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(607, 83);
            this.DescriptionLbl.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // MessageText
            // 
            this.MessageText.BorderColor = System.Drawing.Color.Black;
            this.MessageText.BorderRadius = 5;
            this.MessageText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MessageText.DefaultText = "";
            this.MessageText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MessageText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MessageText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MessageText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MessageText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MessageText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MessageText.ForeColor = System.Drawing.Color.Black;
            this.MessageText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MessageText.Location = new System.Drawing.Point(28, 386);
            this.MessageText.Name = "MessageText";
            this.MessageText.PasswordChar = '\0';
            this.MessageText.PlaceholderText = "";
            this.MessageText.SelectedText = "";
            this.MessageText.Size = new System.Drawing.Size(325, 29);
            this.MessageText.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Write a comment:";
            // 
            // SendBtn
            // 
            this.SendBtn.BorderRadius = 5;
            this.SendBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SendBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SendBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SendBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SendBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SendBtn.ForeColor = System.Drawing.Color.White;
            this.SendBtn.Location = new System.Drawing.Point(360, 386);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(78, 29);
            this.SendBtn.TabIndex = 12;
            this.SendBtn.Text = "Send";
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // CommentsBox
            // 
            this.CommentsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommentsBox.Location = new System.Drawing.Point(27, 421);
            this.CommentsBox.Name = "CommentsBox";
            this.CommentsBox.Size = new System.Drawing.Size(608, 122);
            this.CommentsBox.TabIndex = 13;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Image = global::Project_Management.Properties.Resources.Close__X_;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(629, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.TabIndex = 14;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Start Date: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Due Date:";
            // 
            // Urgency
            // 
            this.Urgency.AutoSize = true;
            this.Urgency.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Urgency.ForeColor = System.Drawing.Color.Red;
            this.Urgency.Location = new System.Drawing.Point(22, 39);
            this.Urgency.Name = "Urgency";
            this.Urgency.Size = new System.Drawing.Size(61, 21);
            this.Urgency.TabIndex = 17;
            this.Urgency.Text = "Urgent";
            // 
            // TagLbl
            // 
            this.TagLbl.AutoSize = true;
            this.TagLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagLbl.Location = new System.Drawing.Point(524, 69);
            this.TagLbl.Name = "TagLbl";
            this.TagLbl.Size = new System.Drawing.Size(35, 21);
            this.TagLbl.TabIndex = 18;
            this.TagLbl.Text = "Tag";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Assigned Members: ";
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Location = new System.Drawing.Point(115, 109);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(17, 21);
            this.StartDate.TabIndex = 20;
            this.StartDate.Text = "/";
            // 
            // DueDate
            // 
            this.DueDate.AutoSize = true;
            this.DueDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDate.Location = new System.Drawing.Point(111, 130);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(17, 21);
            this.DueDate.TabIndex = 21;
            this.DueDate.Text = "/";
            // 
            // MembersText
            // 
            this.MembersText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembersText.Location = new System.Drawing.Point(24, 192);
            this.MembersText.Name = "MembersText";
            this.MembersText.Size = new System.Drawing.Size(610, 48);
            this.MembersText.TabIndex = 22;
            // 
            // TaskOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 557);
            this.Controls.Add(this.MembersText);
            this.Controls.Add(this.DueDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TagLbl);
            this.Controls.Add(this.Urgency);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.CommentsBox);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.ProgressLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskOverview";
            this.Load += new System.EventHandler(this.TaskOverview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public System.Windows.Forms.Label ProgressLbl;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label taskName;
        public System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button SendBtn;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox MessageText;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label MembersText;
        public System.Windows.Forms.Label DueDate;
        public System.Windows.Forms.Label StartDate;
        public System.Windows.Forms.FlowLayoutPanel CommentsBox;
        public System.Windows.Forms.Label TagLbl;
        public System.Windows.Forms.Label Urgency;
    }
}