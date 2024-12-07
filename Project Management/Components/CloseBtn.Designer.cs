namespace Project_Management
{
    partial class CloseBtn
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
            this.close = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.close.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.close.Image = global::Project_Management.Properties.Resources.Close__X_;
            this.close.ImageOffset = new System.Drawing.Point(0, 0);
            this.close.ImageRotate = 0F;
            this.close.ImageSize = new System.Drawing.Size(25, 25);
            this.close.Location = new System.Drawing.Point(0, 0);
            this.close.Name = "close";
            this.close.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.TabIndex = 2;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // CloseBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.close);
            this.Name = "CloseBtn";
            this.Size = new System.Drawing.Size(25, 25);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2ImageButton close;
    }
}
