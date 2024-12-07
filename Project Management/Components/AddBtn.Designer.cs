namespace Project_Management
{
    partial class AddBtn
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
            this.Btn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn
            // 
            this.Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.Btn.Image = global::Project_Management.Properties.Resources.add_blue;
            this.Btn.ImageRotate = 0F;
            this.Btn.Location = new System.Drawing.Point(0, 0);
            this.Btn.Name = "Btn";
            this.Btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Btn.Size = new System.Drawing.Size(25, 25);
            this.Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn.TabIndex = 0;
            this.Btn.TabStop = false;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // AddBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Btn);
            this.Name = "AddBtn";
            this.Size = new System.Drawing.Size(25, 25);
            ((System.ComponentModel.ISupportInitialize)(this.Btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2CirclePictureBox Btn;
    }
}
