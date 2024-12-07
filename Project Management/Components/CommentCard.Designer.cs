namespace Project_Management.Components
{
    partial class CommentCard
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
            this.Comment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Uploader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Comment
            // 
            this.Comment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment.Location = new System.Drawing.Point(12, 9);
            this.Comment.MaximumSize = new System.Drawing.Size(500, 100);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(38, 15);
            this.Comment.TabIndex = 0;
            this.Comment.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "By: ";
            // 
            // Uploader
            // 
            this.Uploader.AutoSize = true;
            this.Uploader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uploader.Location = new System.Drawing.Point(44, 35);
            this.Uploader.Name = "Uploader";
            this.Uploader.Size = new System.Drawing.Size(38, 15);
            this.Uploader.TabIndex = 2;
            this.Uploader.Text = "label1";
            // 
            // CommentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Uploader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Comment);
            this.Name = "CommentCard";
            this.Size = new System.Drawing.Size(574, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label Comment;
        public System.Windows.Forms.Label Uploader;
    }
}
