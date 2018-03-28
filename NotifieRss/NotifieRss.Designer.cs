namespace NotifieRss
{
    partial class NotifieRss_Form
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
            this.URL_Box = new System.Windows.Forms.TextBox();
            this.URL_Label = new System.Windows.Forms.Label();
            this.Keyword_Label = new System.Windows.Forms.Label();
            this.Keyword_Box = new System.Windows.Forms.TextBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.File_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.File_Button = new System.Windows.Forms.Button();
            this.File_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // URL_Box
            // 
            this.URL_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URL_Box.Location = new System.Drawing.Point(12, 12);
            this.URL_Box.Name = "URL_Box";
            this.URL_Box.Size = new System.Drawing.Size(271, 20);
            this.URL_Box.TabIndex = 0;
            this.URL_Box.WordWrap = false;
            this.URL_Box.TextChanged += new System.EventHandler(this.URL_Box_TextChanged);
            // 
            // URL_Label
            // 
            this.URL_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.URL_Label.AutoSize = true;
            this.URL_Label.Location = new System.Drawing.Point(289, 15);
            this.URL_Label.Name = "URL_Label";
            this.URL_Label.Size = new System.Drawing.Size(29, 13);
            this.URL_Label.TabIndex = 0;
            this.URL_Label.Text = "URL";
            // 
            // Keyword_Label
            // 
            this.Keyword_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Keyword_Label.AutoSize = true;
            this.Keyword_Label.Location = new System.Drawing.Point(289, 41);
            this.Keyword_Label.Name = "Keyword_Label";
            this.Keyword_Label.Size = new System.Drawing.Size(48, 13);
            this.Keyword_Label.TabIndex = 1;
            this.Keyword_Label.Text = "Keyword";
            // 
            // Keyword_Box
            // 
            this.Keyword_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Keyword_Box.Location = new System.Drawing.Point(12, 38);
            this.Keyword_Box.Name = "Keyword_Box";
            this.Keyword_Box.Size = new System.Drawing.Size(271, 20);
            this.Keyword_Box.TabIndex = 1;
            this.Keyword_Box.WordWrap = false;
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK_Button.Enabled = false;
            this.OK_Button.Location = new System.Drawing.Point(197, 103);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 4;
            this.OK_Button.Text = "Start";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel_Button.Enabled = false;
            this.Cancel_Button.Location = new System.Drawing.Point(278, 103);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 4;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // File_Dialog
            // 
            this.File_Dialog.FileName = "Sound";
            this.File_Dialog.Filter = "All files|*.*";
            this.File_Dialog.RestoreDirectory = true;
            this.File_Dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.File_Dialog_FileOk);
            // 
            // File_Button
            // 
            this.File_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.File_Button.Location = new System.Drawing.Point(289, 62);
            this.File_Button.Name = "File_Button";
            this.File_Button.Size = new System.Drawing.Size(64, 23);
            this.File_Button.TabIndex = 3;
            this.File_Button.Text = "Sound...";
            this.File_Button.UseVisualStyleBackColor = true;
            this.File_Button.Click += new System.EventHandler(this.File_Button_Click);
            // 
            // File_Box
            // 
            this.File_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.File_Box.Enabled = false;
            this.File_Box.Location = new System.Drawing.Point(12, 64);
            this.File_Box.Name = "File_Box";
            this.File_Box.ReadOnly = true;
            this.File_Box.Size = new System.Drawing.Size(271, 20);
            this.File_Box.TabIndex = 3;
            this.File_Box.TabStop = false;
            // 
            // NotifieRss_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(365, 138);
            this.Controls.Add(this.File_Box);
            this.Controls.Add(this.File_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.Keyword_Box);
            this.Controls.Add(this.Keyword_Label);
            this.Controls.Add(this.URL_Label);
            this.Controls.Add(this.URL_Box);
            this.MaximizeBox = false;
            this.Name = "NotifieRss_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "NotifieRSS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URL_Box;
        private System.Windows.Forms.Label URL_Label;
        private System.Windows.Forms.Label Keyword_Label;
        private System.Windows.Forms.TextBox Keyword_Box;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.OpenFileDialog File_Dialog;
        private System.Windows.Forms.Button File_Button;
        private System.Windows.Forms.TextBox File_Box;
    }
}

