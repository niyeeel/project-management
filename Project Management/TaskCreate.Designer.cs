namespace Project_Management
{
    partial class TaskCreate
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
            this.TaskNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TagDown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DescTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.TaskStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DueDateBox = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Urgency = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn1 = new Project_Management.Btn();
            this.cancelBtn1 = new Project_Management.Components.CancelBtn();
            this.label8 = new System.Windows.Forms.Label();
            this.AssignedList = new System.Windows.Forms.FlowLayoutPanel();
            this.YouCard = new Project_Management.Components.AssignedCard();
            this.addBtn1 = new Project_Management.AddBtn();
            this.AssignedList.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Task";
            // 
            // TaskNameTxt
            // 
            this.TaskNameTxt.BorderColor = System.Drawing.Color.Black;
            this.TaskNameTxt.BorderRadius = 5;
            this.TaskNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TaskNameTxt.DefaultText = "";
            this.TaskNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TaskNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TaskNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TaskNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TaskNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TaskNameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TaskNameTxt.ForeColor = System.Drawing.Color.Black;
            this.TaskNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TaskNameTxt.Location = new System.Drawing.Point(17, 74);
            this.TaskNameTxt.Name = "TaskNameTxt";
            this.TaskNameTxt.PasswordChar = '\0';
            this.TaskNameTxt.PlaceholderText = "Task Name";
            this.TaskNameTxt.SelectedText = "";
            this.TaskNameTxt.Size = new System.Drawing.Size(255, 39);
            this.TaskNameTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Task Name";
            // 
            // TagDown
            // 
            this.TagDown.BackColor = System.Drawing.Color.Transparent;
            this.TagDown.BorderColor = System.Drawing.Color.Black;
            this.TagDown.BorderRadius = 5;
            this.TagDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TagDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TagDown.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TagDown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TagDown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TagDown.ForeColor = System.Drawing.Color.Black;
            this.TagDown.ItemHeight = 30;
            this.TagDown.Items.AddRange(new object[] {
            "UI/UX Design",
            "Finance",
            "Feature",
            "Documentation",
            "IT ",
            "Graphics Design"});
            this.TagDown.Location = new System.Drawing.Point(301, 77);
            this.TagDown.Name = "TagDown";
            this.TagDown.Size = new System.Drawing.Size(140, 36);
            this.TagDown.StartIndex = 0;
            this.TagDown.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tag";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // DescTxt
            // 
            this.DescTxt.BorderColor = System.Drawing.Color.Black;
            this.DescTxt.BorderRadius = 5;
            this.DescTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescTxt.DefaultText = "";
            this.DescTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DescTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DescTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DescTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DescTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DescTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DescTxt.ForeColor = System.Drawing.Color.Black;
            this.DescTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DescTxt.Location = new System.Drawing.Point(17, 267);
            this.DescTxt.Name = "DescTxt";
            this.DescTxt.PasswordChar = '\0';
            this.DescTxt.PlaceholderText = "Description";
            this.DescTxt.SelectedText = "";
            this.DescTxt.Size = new System.Drawing.Size(424, 71);
            this.DescTxt.TabIndex = 5;
            // 
            // TaskStart
            // 
            this.TaskStart.BackColor = System.Drawing.Color.White;
            this.TaskStart.BorderRadius = 5;
            this.TaskStart.BorderThickness = 1;
            this.TaskStart.Checked = true;
            this.TaskStart.FillColor = System.Drawing.Color.White;
            this.TaskStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TaskStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TaskStart.Location = new System.Drawing.Point(17, 139);
            this.TaskStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TaskStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TaskStart.Name = "TaskStart";
            this.TaskStart.Size = new System.Drawing.Size(132, 36);
            this.TaskStart.TabIndex = 7;
            this.TaskStart.Value = new System.DateTime(2024, 11, 25, 21, 53, 33, 891);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Task Start";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Due Date";
            // 
            // DueDateBox
            // 
            this.DueDateBox.BackColor = System.Drawing.Color.White;
            this.DueDateBox.BorderRadius = 5;
            this.DueDateBox.BorderThickness = 1;
            this.DueDateBox.Checked = true;
            this.DueDateBox.FillColor = System.Drawing.Color.White;
            this.DueDateBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DueDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DueDateBox.Location = new System.Drawing.Point(172, 139);
            this.DueDateBox.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DueDateBox.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DueDateBox.Name = "DueDateBox";
            this.DueDateBox.Size = new System.Drawing.Size(132, 36);
            this.DueDateBox.TabIndex = 9;
            this.DueDateBox.Value = new System.DateTime(2024, 11, 25, 21, 53, 33, 891);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Urgency";
            // 
            // Urgency
            // 
            this.Urgency.BackColor = System.Drawing.Color.Transparent;
            this.Urgency.BorderColor = System.Drawing.Color.Black;
            this.Urgency.BorderRadius = 5;
            this.Urgency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Urgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Urgency.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Urgency.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Urgency.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Urgency.ForeColor = System.Drawing.Color.Black;
            this.Urgency.ItemHeight = 30;
            this.Urgency.Items.AddRange(new object[] {
            "Urgent and Important",
            "Not Urgent but Important",
            "Urgent but Not Important",
            "Neither Urgent nor Important"});
            this.Urgency.Location = new System.Drawing.Point(17, 204);
            this.Urgency.Name = "Urgency";
            this.Urgency.Size = new System.Drawing.Size(234, 36);
            this.Urgency.StartIndex = 1;
            this.Urgency.TabIndex = 11;
            // 
            // btn1
            // 
            this.btn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.btn1.BorderColor = System.Drawing.Color.Empty;
            this.btn1.BorderThickness = 0;
            this.btn1.Dimentions = new System.Drawing.Size(180, 45);
            this.btn1.Location = new System.Drawing.Point(261, 492);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(180, 45);
            this.btn1.TabIndex = 13;
            this.btn1.TextColor = System.Drawing.Color.White;
            this.btn1.TextValue = "Create Task";
            this.btn1.Load += new System.EventHandler(this.btn1_Load);
            // 
            // cancelBtn1
            // 
            this.cancelBtn1.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn1.Location = new System.Drawing.Point(17, 492);
            this.cancelBtn1.Name = "cancelBtn1";
            this.cancelBtn1.Size = new System.Drawing.Size(182, 45);
            this.cancelBtn1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Assigned Member/s";
            // 
            // AssignedList
            // 
            this.AssignedList.AutoScroll = true;
            this.AssignedList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssignedList.Controls.Add(this.YouCard);
            this.AssignedList.Location = new System.Drawing.Point(17, 379);
            this.AssignedList.Name = "AssignedList";
            this.AssignedList.Size = new System.Drawing.Size(424, 107);
            this.AssignedList.TabIndex = 15;
            // 
            // YouCard
            // 
            this.YouCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YouCard.Location = new System.Drawing.Point(3, 3);
            this.YouCard.Name = "YouCard";
            this.YouCard.Size = new System.Drawing.Size(408, 38);
            this.YouCard.TabIndex = 0;
            // 
            // addBtn1
            // 
            this.addBtn1.BackColor = System.Drawing.Color.Transparent;
            this.addBtn1.Location = new System.Drawing.Point(416, 348);
            this.addBtn1.Name = "addBtn1";
            this.addBtn1.Size = new System.Drawing.Size(25, 25);
            this.addBtn1.TabIndex = 17;
            this.addBtn1.Load += new System.EventHandler(this.addBtn1_Load);
            // 
            // TaskCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 549);
            this.Controls.Add(this.addBtn1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AssignedList);
            this.Controls.Add(this.cancelBtn1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Urgency);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DueDateBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TaskStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DescTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TagDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TaskNameTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskCreate";
            this.Load += new System.EventHandler(this.TaskCreate_Load);
            this.AssignedList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TaskNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox DescTxt;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox TagDown;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker DueDateBox;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker TaskStart;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox Urgency;
        private Btn btn1;
        private Components.CancelBtn cancelBtn1;
        private System.Windows.Forms.Label label8;
        private AddBtn addBtn1;
        public System.Windows.Forms.FlowLayoutPanel AssignedList;
        public Components.AssignedCard YouCard;
    }
}