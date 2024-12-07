namespace Project_Management
{
    partial class TaskCard
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
            this.TaskNameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DueLbl = new System.Windows.Forms.Label();
            this.MembersLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskNameLbl
            // 
            this.TaskNameLbl.AutoSize = true;
            this.TaskNameLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameLbl.Location = new System.Drawing.Point(13, 9);
            this.TaskNameLbl.Name = "TaskNameLbl";
            this.TaskNameLbl.Size = new System.Drawing.Size(40, 20);
            this.TaskNameLbl.TabIndex = 0;
            this.TaskNameLbl.Text = "Task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Due Date: ";
            // 
            // DueLbl
            // 
            this.DueLbl.AutoSize = true;
            this.DueLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueLbl.Location = new System.Drawing.Point(83, 37);
            this.DueLbl.Name = "DueLbl";
            this.DueLbl.Size = new System.Drawing.Size(59, 15);
            this.DueLbl.TabIndex = 2;
            this.DueLbl.Text = "00/00/00";
            // 
            // MembersLbl
            // 
            this.MembersLbl.AutoSize = true;
            this.MembersLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembersLbl.Location = new System.Drawing.Point(243, 13);
            this.MembersLbl.Name = "MembersLbl";
            this.MembersLbl.Size = new System.Drawing.Size(14, 15);
            this.MembersLbl.TabIndex = 3;
            this.MembersLbl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(189, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Members Assigned";
            // 
            // TaskCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MembersLbl);
            this.Controls.Add(this.DueLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TaskNameLbl);
            this.Name = "TaskCard";
            this.Size = new System.Drawing.Size(300, 58);
            this.Load += new System.EventHandler(this.TaskCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label TaskNameLbl;
        public System.Windows.Forms.Label DueLbl;
        public System.Windows.Forms.Label MembersLbl;
    }
}
