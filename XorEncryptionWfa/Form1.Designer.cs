namespace XorEncryptionWfa
{
    partial class Form1
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
            this.InputLabel = new System.Windows.Forms.Label();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.KeyBoxFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EncryptFileButton = new System.Windows.Forms.Button();
            this.DecryptFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FilePathBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ExtractedHashBox = new System.Windows.Forms.TextBox();
            this.HashLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(8, 25);
            this.InputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(31, 13);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "Input";
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(13, 51);
            this.KeyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(25, 13);
            this.KeyLabel.TabIndex = 1;
            this.KeyLabel.Text = "Key";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(-2, 77);
            this.OutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(39, 13);
            this.OutputLabel.TabIndex = 2;
            this.OutputLabel.Text = "Output";
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(46, 25);
            this.InputBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(156, 20);
            this.InputBox.TabIndex = 3;
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(46, 51);
            this.KeyBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(156, 20);
            this.KeyBox.TabIndex = 4;
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(46, 77);
            this.OutputBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(156, 20);
            this.OutputBox.TabIndex = 5;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(224, 20);
            this.EncryptButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(56, 23);
            this.EncryptButton.TabIndex = 6;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(224, 51);
            this.DecryptButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(56, 23);
            this.DecryptButton.TabIndex = 7;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DecryptButton);
            this.groupBox1.Controls.Add(this.InputLabel);
            this.groupBox1.Controls.Add(this.EncryptButton);
            this.groupBox1.Controls.Add(this.KeyLabel);
            this.groupBox1.Controls.Add(this.OutputBox);
            this.groupBox1.Controls.Add(this.OutputLabel);
            this.groupBox1.Controls.Add(this.KeyBox);
            this.groupBox1.Controls.Add(this.InputBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(307, 111);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HashLabel);
            this.groupBox2.Controls.Add(this.ExtractedHashBox);
            this.groupBox2.Controls.Add(this.KeyBoxFile);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.EncryptFileButton);
            this.groupBox2.Controls.Add(this.DecryptFileButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.FilePathBox);
            this.groupBox2.Controls.Add(this.BrowseButton);
            this.groupBox2.Location = new System.Drawing.Point(9, 126);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(307, 111);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // KeyBoxFile
            // 
            this.KeyBoxFile.Location = new System.Drawing.Point(46, 46);
            this.KeyBoxFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KeyBoxFile.Name = "KeyBoxFile";
            this.KeyBoxFile.Size = new System.Drawing.Size(156, 20);
            this.KeyBoxFile.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Key";
            // 
            // EncryptFileButton
            // 
            this.EncryptFileButton.Location = new System.Drawing.Point(224, 47);
            this.EncryptFileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EncryptFileButton.Name = "EncryptFileButton";
            this.EncryptFileButton.Size = new System.Drawing.Size(56, 23);
            this.EncryptFileButton.TabIndex = 9;
            this.EncryptFileButton.Text = "Encrypt";
            this.EncryptFileButton.UseVisualStyleBackColor = true;
            this.EncryptFileButton.Click += new System.EventHandler(this.EncryptFileButton_Click);
            // 
            // DecryptFileButton
            // 
            this.DecryptFileButton.Location = new System.Drawing.Point(224, 77);
            this.DecryptFileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DecryptFileButton.Name = "DecryptFileButton";
            this.DecryptFileButton.Size = new System.Drawing.Size(56, 23);
            this.DecryptFileButton.TabIndex = 10;
            this.DecryptFileButton.Text = "Decrypt";
            this.DecryptFileButton.UseVisualStyleBackColor = true;
            this.DecryptFileButton.Click += new System.EventHandler(this.DecryptFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "File";
            // 
            // FilePathBox
            // 
            this.FilePathBox.Location = new System.Drawing.Point(46, 22);
            this.FilePathBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilePathBox.Name = "FilePathBox";
            this.FilePathBox.Size = new System.Drawing.Size(156, 20);
            this.FilePathBox.TabIndex = 9;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(224, 17);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(56, 23);
            this.BrowseButton.TabIndex = 10;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // ExtractedHashBox
            // 
            this.ExtractedHashBox.Location = new System.Drawing.Point(46, 70);
            this.ExtractedHashBox.Margin = new System.Windows.Forms.Padding(2);
            this.ExtractedHashBox.Name = "ExtractedHashBox";
            this.ExtractedHashBox.Size = new System.Drawing.Size(156, 20);
            this.ExtractedHashBox.TabIndex = 13;
            // 
            // HashLabel
            // 
            this.HashLabel.AutoSize = true;
            this.HashLabel.Location = new System.Drawing.Point(14, 70);
            this.HashLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HashLabel.Name = "HashLabel";
            this.HashLabel.Size = new System.Drawing.Size(32, 13);
            this.HashLabel.TabIndex = 14;
            this.HashLabel.Text = "Hash";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 259);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "EncryptionUtility";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilePathBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button EncryptFileButton;
        private System.Windows.Forms.Button DecryptFileButton;
        private System.Windows.Forms.TextBox KeyBoxFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HashLabel;
        private System.Windows.Forms.TextBox ExtractedHashBox;
    }
}

