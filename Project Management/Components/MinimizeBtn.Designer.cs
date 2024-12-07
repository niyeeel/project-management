namespace Project_Management
{
    partial class MinimizeBtn
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
            this.minimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // minimize
            // 
            this.minimize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.minimize.HoverState.ImageSize = new System.Drawing.Size(25, 5);
            this.minimize.Image = global::Project_Management.Properties.Resources.minimize;
            this.minimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.minimize.ImageRotate = 0F;
            this.minimize.ImageSize = new System.Drawing.Size(25, 5);
            this.minimize.Location = new System.Drawing.Point(0, 0);
            this.minimize.Name = "minimize";
            this.minimize.PressedState.ImageSize = new System.Drawing.Size(25, 5);
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.TabIndex = 2;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // MinimizeBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.minimize);
            this.Name = "MinimizeBtn";
            this.Size = new System.Drawing.Size(25, 25);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2ImageButton minimize;
    }
}
