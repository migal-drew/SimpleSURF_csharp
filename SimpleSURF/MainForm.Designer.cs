namespace SimpleSURF
{
    partial class MainForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.txtBoxThreshold = new System.Windows.Forms.TextBox();
            this.txtBoxBottomOct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxTopOct = new System.Windows.Forms.TextBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.clrDial = new System.Windows.Forms.ColorDialog();
            this.btnPosColor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(545, 375);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Find!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.Location = new System.Drawing.Point(0, 3);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(525, 366);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // txtBoxThreshold
            // 
            this.txtBoxThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxThreshold.Location = new System.Drawing.Point(545, 52);
            this.txtBoxThreshold.Name = "txtBoxThreshold";
            this.txtBoxThreshold.Size = new System.Drawing.Size(84, 20);
            this.txtBoxThreshold.TabIndex = 2;
            this.txtBoxThreshold.Text = "0,001";
            // 
            // txtBoxBottomOct
            // 
            this.txtBoxBottomOct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxBottomOct.Location = new System.Drawing.Point(545, 107);
            this.txtBoxBottomOct.Name = "txtBoxBottomOct";
            this.txtBoxBottomOct.Size = new System.Drawing.Size(84, 20);
            this.txtBoxBottomOct.TabIndex = 3;
            this.txtBoxBottomOct.Text = "2";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Threshold";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bottom octave";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Top octave";
            // 
            // txtBoxTopOct
            // 
            this.txtBoxTopOct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTopOct.Location = new System.Drawing.Point(545, 159);
            this.txtBoxTopOct.Name = "txtBoxTopOct";
            this.txtBoxTopOct.Size = new System.Drawing.Size(84, 20);
            this.txtBoxTopOct.TabIndex = 7;
            this.txtBoxTopOct.Text = "2";
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenImage.Location = new System.Drawing.Point(437, 375);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(75, 23);
            this.btnOpenImage.TabIndex = 8;
            this.btnOpenImage.Text = "Open...";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnStats
            // 
            this.btnStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStats.Location = new System.Drawing.Point(545, 195);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(84, 23);
            this.btnStats.TabIndex = 9;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnPosColor
            // 
            this.btnPosColor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPosColor.Location = new System.Drawing.Point(531, 255);
            this.btnPosColor.Name = "btnPosColor";
            this.btnPosColor.Size = new System.Drawing.Size(98, 23);
            this.btnPosColor.TabIndex = 10;
            this.btnPosColor.Text = "Positive Color";
            this.btnPosColor.UseVisualStyleBackColor = true;
            this.btnPosColor.Click += new System.EventHandler(this.btnPosColor_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(531, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Negative Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 410);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPosColor);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.txtBoxTopOct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxBottomOct);
            this.Controls.Add(this.txtBoxThreshold);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "Simple Surf";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TextBox txtBoxThreshold;
        private System.Windows.Forms.TextBox txtBoxBottomOct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxTopOct;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.ColorDialog clrDial;
        private System.Windows.Forms.Button btnPosColor;
        private System.Windows.Forms.Button button1;
    }
}

