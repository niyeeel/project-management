﻿namespace Project_Management
{
    partial class nav
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
            this.close = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
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
            this.minimize.Location = new System.Drawing.Point(963, 11);
            this.minimize.Name = "minimize";
            this.minimize.PressedState.ImageSize = new System.Drawing.Size(25, 5);
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.TabIndex = 1;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.close.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.close.Image = global::Project_Management.Properties.Resources.Close__X_;
            this.close.ImageOffset = new System.Drawing.Point(0, 0);
            this.close.ImageRotate = 0F;
            this.close.ImageSize = new System.Drawing.Size(25, 25);
            this.close.Location = new System.Drawing.Point(1017, 11);
            this.close.Name = "close";
            this.close.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.TabIndex = 0;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Project_Management.Properties.Resources.LogoPM;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(14, 11);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // nav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Name = "nav";
            this.Size = new System.Drawing.Size(1060, 50);
            this.Load += new System.EventHandler(this.nav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2ImageButton close;
        public Guna.UI2.WinForms.Guna2ImageButton minimize;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}
