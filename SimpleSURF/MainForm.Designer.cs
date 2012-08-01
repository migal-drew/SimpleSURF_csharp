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
            this.picBox_1 = new System.Windows.Forms.PictureBox();
            this.txtBoxThreshold = new System.Windows.Forms.TextBox();
            this.txtBoxBottomOct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxTopOct = new System.Windows.Forms.TextBox();
            this.btnOpenImage_1 = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.clrDial = new System.Windows.Forms.ColorDialog();
            this.btnPosColor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picBox_2 = new System.Windows.Forms.PictureBox();
            this.btnOpenImage_2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(982, 658);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Find!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picBox_1
            // 
            this.picBox_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox_1.Location = new System.Drawing.Point(0, 3);
            this.picBox_1.Name = "picBox_1";
            this.picBox_1.Size = new System.Drawing.Size(483, 644);
            this.picBox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_1.TabIndex = 1;
            this.picBox_1.TabStop = false;
            // 
            // txtBoxThreshold
            // 
            this.txtBoxThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxThreshold.Location = new System.Drawing.Point(982, 52);
            this.txtBoxThreshold.Name = "txtBoxThreshold";
            this.txtBoxThreshold.Size = new System.Drawing.Size(84, 20);
            this.txtBoxThreshold.TabIndex = 2;
            this.txtBoxThreshold.Text = "0,001";
            // 
            // txtBoxBottomOct
            // 
            this.txtBoxBottomOct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxBottomOct.Location = new System.Drawing.Point(982, 107);
            this.txtBoxBottomOct.Name = "txtBoxBottomOct";
            this.txtBoxBottomOct.Size = new System.Drawing.Size(84, 20);
            this.txtBoxBottomOct.TabIndex = 3;
            this.txtBoxBottomOct.Text = "2";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(982, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Threshold";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(982, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bottom octave";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(979, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Top octave";
            // 
            // txtBoxTopOct
            // 
            this.txtBoxTopOct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTopOct.Location = new System.Drawing.Point(982, 159);
            this.txtBoxTopOct.Name = "txtBoxTopOct";
            this.txtBoxTopOct.Size = new System.Drawing.Size(84, 20);
            this.txtBoxTopOct.TabIndex = 7;
            this.txtBoxTopOct.Text = "2";
            // 
            // btnOpenImage_1
            // 
            this.btnOpenImage_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenImage_1.Location = new System.Drawing.Point(257, 658);
            this.btnOpenImage_1.Name = "btnOpenImage_1";
            this.btnOpenImage_1.Size = new System.Drawing.Size(75, 23);
            this.btnOpenImage_1.TabIndex = 8;
            this.btnOpenImage_1.Text = "Open...";
            this.btnOpenImage_1.UseVisualStyleBackColor = true;
            this.btnOpenImage_1.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnStats
            // 
            this.btnStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStats.Location = new System.Drawing.Point(982, 195);
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
            this.btnPosColor.Location = new System.Drawing.Point(968, 331);
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
            this.button1.Location = new System.Drawing.Point(968, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Negative Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBox_2
            // 
            this.picBox_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox_2.Location = new System.Drawing.Point(489, 3);
            this.picBox_2.Name = "picBox_2";
            this.picBox_2.Size = new System.Drawing.Size(473, 644);
            this.picBox_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_2.TabIndex = 12;
            this.picBox_2.TabStop = false;
            // 
            // btnOpenImage_2
            // 
            this.btnOpenImage_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenImage_2.Location = new System.Drawing.Point(707, 658);
            this.btnOpenImage_2.Name = "btnOpenImage_2";
            this.btnOpenImage_2.Size = new System.Drawing.Size(75, 23);
            this.btnOpenImage_2.TabIndex = 13;
            this.btnOpenImage_2.Text = "Open...";
            this.btnOpenImage_2.UseVisualStyleBackColor = true;
            this.btnOpenImage_2.Click += new System.EventHandler(this.btnOpenImage_2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 693);
            this.Controls.Add(this.btnOpenImage_2);
            this.Controls.Add(this.picBox_2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPosColor);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnOpenImage_1);
            this.Controls.Add(this.txtBoxTopOct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxBottomOct);
            this.Controls.Add(this.txtBoxThreshold);
            this.Controls.Add(this.picBox_1);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "Simple Surf";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picBox_1;
        private System.Windows.Forms.TextBox txtBoxThreshold;
        private System.Windows.Forms.TextBox txtBoxBottomOct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxTopOct;
        private System.Windows.Forms.Button btnOpenImage_1;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.ColorDialog clrDial;
        private System.Windows.Forms.Button btnPosColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picBox_2;
        private System.Windows.Forms.Button btnOpenImage_2;
    }
}

