namespace SimpleSURF
{
    partial class PreviewForm
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
            this.picBoxPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxPreview
            // 
            this.picBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxPreview.Location = new System.Drawing.Point(2, 2);
            this.picBoxPreview.Name = "picBoxPreview";
            this.picBoxPreview.Size = new System.Drawing.Size(635, 366);
            this.picBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPreview.TabIndex = 0;
            this.picBoxPreview.TabStop = false;
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 380);
            this.Controls.Add(this.picBoxPreview);
            this.Name = "PreviewForm";
            this.Text = "Preview";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxPreview;
    }
}