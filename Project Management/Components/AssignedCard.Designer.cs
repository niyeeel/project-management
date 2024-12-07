namespace Project_Management.Components
{
    partial class AssignedCard
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
            this.MinusBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.UserLTR = new Project_Management.Components.UserCircle();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(55, 8);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(51, 21);
            this.Username.TabIndex = 0;
            this.Username.Text = "label1";
            // 
            // MinusBtn
            // 
            this.MinusBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.MinusBtn.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.MinusBtn.Image = global::Project_Management.Properties.Resources.minus;
            this.MinusBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.MinusBtn.ImageRotate = 0F;
            this.MinusBtn.Location = new System.Drawing.Point(363, 15);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.MinusBtn.Size = new System.Drawing.Size(30, 8);
            this.MinusBtn.TabIndex = 23;
            // 
            // UserLTR
            // 
            this.UserLTR.BackColor = System.Drawing.Color.Transparent;
            this.UserLTR.Location = new System.Drawing.Point(14, 6);
            this.UserLTR.Name = "UserLTR";
            this.UserLTR.Size = new System.Drawing.Size(26, 26);
            this.UserLTR.TabIndex = 24;
            // 
            // AssignedCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.UserLTR);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.Username);
            this.Name = "AssignedCard";
            this.Size = new System.Drawing.Size(408, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2ImageButton MinusBtn;
        public System.Windows.Forms.Label Username;
        public UserCircle UserLTR;
    }
}
