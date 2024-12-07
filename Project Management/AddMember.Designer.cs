namespace Project_Management
{
    partial class AddMember
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
            this.btn1 = new Project_Management.Btn();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.username1 = new Project_Management.Username();
            this.cancelBtn1 = new Project_Management.Components.CancelBtn();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btn1
            // 
            this.btn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.btn1.BorderColor = System.Drawing.Color.Empty;
            this.btn1.BorderThickness = 0;
            this.btn1.Dimentions = new System.Drawing.Size(180, 45);
            this.btn1.Location = new System.Drawing.Point(198, 90);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(180, 45);
            this.btn1.TabIndex = 0;
            this.btn1.TextColor = System.Drawing.Color.White;
            this.btn1.TextValue = "Add";
            this.btn1.Load += new System.EventHandler(this.btn1_Load);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(72, 22);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Username";
            // 
            // username1
            // 
            this.username1.BackColor = System.Drawing.Color.Transparent;
            this.username1.Location = new System.Drawing.Point(12, 37);
            this.username1.Name = "username1";
            this.username1.PlaceHolder = "Enter Member\'s Username";
            this.username1.Size = new System.Drawing.Size(292, 32);
            this.username1.TabIndex = 4;
            // 
            // cancelBtn1
            // 
            this.cancelBtn1.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn1.Location = new System.Drawing.Point(10, 91);
            this.cancelBtn1.Name = "cancelBtn1";
            this.cancelBtn1.Size = new System.Drawing.Size(182, 45);
            this.cancelBtn1.TabIndex = 5;
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 148);
            this.Controls.Add(this.cancelBtn1);
            this.Controls.Add(this.username1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMember";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Btn btn1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Username username1;
        private Components.CancelBtn cancelBtn1;
    }
}