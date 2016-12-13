namespace FilesLister
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartPath = new System.Windows.Forms.TextBox();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkIsRelative = new System.Windows.Forms.CheckBox();
            this.checkOpenWhenDone = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Folder Path";
            // 
            // txtStartPath
            // 
            this.txtStartPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartPath.Location = new System.Drawing.Point(160, 18);
            this.txtStartPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartPath.Name = "txtStartPath";
            this.txtStartPath.Size = new System.Drawing.Size(445, 27);
            this.txtStartPath.TabIndex = 0;
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputPath.Location = new System.Drawing.Point(160, 56);
            this.txtOutputPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(445, 27);
            this.txtOutputPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output Path";
            // 
            // txtExtension
            // 
            this.txtExtension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExtension.Location = new System.Drawing.Point(160, 94);
            this.txtExtension.Margin = new System.Windows.Forms.Padding(4);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(445, 27);
            this.txtExtension.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lookup Extension";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(493, 289);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 34);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(22, 289);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(463, 34);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 8;
            this.progressBar.Visible = false;
            // 
            // txtPrefix
            // 
            this.txtPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrefix.Location = new System.Drawing.Point(160, 169);
            this.txtPrefix.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(445, 27);
            this.txtPrefix.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Prefix";
            // 
            // txtSuffix
            // 
            this.txtSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuffix.Location = new System.Drawing.Point(160, 204);
            this.txtSuffix.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(445, 27);
            this.txtSuffix.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Suffix";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(19, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Created By Feras Dawod";
            // 
            // checkIsRelative
            // 
            this.checkIsRelative.AutoSize = true;
            this.checkIsRelative.Checked = true;
            this.checkIsRelative.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIsRelative.Location = new System.Drawing.Point(160, 128);
            this.checkIsRelative.Name = "checkIsRelative";
            this.checkIsRelative.Size = new System.Drawing.Size(180, 23);
            this.checkIsRelative.TabIndex = 14;
            this.checkIsRelative.Text = "Output Relative Paths";
            this.checkIsRelative.UseVisualStyleBackColor = true;
            // 
            // checkOpenWhenDone
            // 
            this.checkOpenWhenDone.AutoSize = true;
            this.checkOpenWhenDone.Checked = true;
            this.checkOpenWhenDone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkOpenWhenDone.Location = new System.Drawing.Point(160, 238);
            this.checkOpenWhenDone.Name = "checkOpenWhenDone";
            this.checkOpenWhenDone.Size = new System.Drawing.Size(182, 23);
            this.checkOpenWhenDone.TabIndex = 15;
            this.checkOpenWhenDone.Text = "Open File When Done";
            this.checkOpenWhenDone.UseVisualStyleBackColor = true;
            this.checkOpenWhenDone.Visible = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 349);
            this.Controls.Add(this.checkOpenWhenDone);
            this.Controls.Add(this.checkIsRelative);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSuffix);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStartPath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Lister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStartPath;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkIsRelative;
        private System.Windows.Forms.CheckBox checkOpenWhenDone;
    }
}

