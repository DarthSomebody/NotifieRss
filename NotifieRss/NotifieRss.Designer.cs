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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader Column_URL;
            System.Windows.Forms.ColumnHeader Column_File;
            System.Windows.Forms.ColumnHeader Column_Keywords;
            System.Windows.Forms.GroupBox Add_Group;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifieRss_Form));
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Autostart_Checkbox = new System.Windows.Forms.CheckBox();
            this.File_Label = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.URL_Box = new System.Windows.Forms.TextBox();
            this.Keyword_Box = new System.Windows.Forms.TextBox();
            this.File_Button = new System.Windows.Forms.Button();
            this.File_Box = new System.Windows.Forms.TextBox();
            this.URL_Label = new System.Windows.Forms.Label();
            this.Keyword_Label = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.File_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.TaskListView = new System.Windows.Forms.ListView();
            this.Column_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remove_Button = new System.Windows.Forms.Button();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            Column_URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Column_File = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Column_Keywords = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Add_Group = new System.Windows.Forms.GroupBox();
            Add_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column_URL
            // 
            Column_URL.Text = "URL";
            Column_URL.Width = 108;
            // 
            // Column_File
            // 
            Column_File.Text = "File";
            Column_File.Width = 135;
            // 
            // Column_Keywords
            // 
            Column_Keywords.Text = "Keyword";
            Column_Keywords.Width = 90;
            // 
            // Add_Group
            // 
            Add_Group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            Add_Group.Controls.Add(this.Clear_Button);
            Add_Group.Controls.Add(this.Autostart_Checkbox);
            Add_Group.Controls.Add(this.File_Label);
            Add_Group.Controls.Add(this.Add_Button);
            Add_Group.Controls.Add(this.URL_Box);
            Add_Group.Controls.Add(this.Keyword_Box);
            Add_Group.Controls.Add(this.File_Button);
            Add_Group.Controls.Add(this.File_Box);
            Add_Group.Controls.Add(this.URL_Label);
            Add_Group.Controls.Add(this.Keyword_Label);
            Add_Group.Location = new System.Drawing.Point(12, 12);
            Add_Group.Name = "Add_Group";
            Add_Group.Size = new System.Drawing.Size(400, 136);
            Add_Group.TabIndex = 6;
            Add_Group.TabStop = false;
            Add_Group.Text = "Add Task";
            // 
            // Clear_Button
            // 
            this.Clear_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear_Button.CausesValidation = false;
            this.Clear_Button.Location = new System.Drawing.Point(226, 107);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(75, 23);
            this.Clear_Button.TabIndex = 7;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Autostart_Checkbox
            // 
            this.Autostart_Checkbox.AutoSize = true;
            this.Autostart_Checkbox.CausesValidation = false;
            this.Autostart_Checkbox.Checked = true;
            this.Autostart_Checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Autostart_Checkbox.Location = new System.Drawing.Point(60, 102);
            this.Autostart_Checkbox.Name = "Autostart_Checkbox";
            this.Autostart_Checkbox.Size = new System.Drawing.Size(68, 17);
            this.Autostart_Checkbox.TabIndex = 6;
            this.Autostart_Checkbox.Text = "Autostart";
            this.Autostart_Checkbox.UseVisualStyleBackColor = true;
            // 
            // File_Label
            // 
            this.File_Label.AutoSize = true;
            this.File_Label.Location = new System.Drawing.Point(6, 80);
            this.File_Label.Name = "File_Label";
            this.File_Label.Size = new System.Drawing.Size(23, 13);
            this.File_Label.TabIndex = 5;
            this.File_Label.Text = "File";
            // 
            // Add_Button
            // 
            this.Add_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_Button.CausesValidation = false;
            this.Add_Button.Location = new System.Drawing.Point(307, 107);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(87, 23);
            this.Add_Button.TabIndex = 4;
            this.Add_Button.Text = "Add Task";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // URL_Box
            // 
            this.URL_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URL_Box.CausesValidation = false;
            this.URL_Box.Location = new System.Drawing.Point(60, 24);
            this.URL_Box.Name = "URL_Box";
            this.URL_Box.Size = new System.Drawing.Size(334, 20);
            this.URL_Box.TabIndex = 0;
            this.URL_Box.WordWrap = false;
            // 
            // Keyword_Box
            // 
            this.Keyword_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Keyword_Box.CausesValidation = false;
            this.Keyword_Box.Location = new System.Drawing.Point(60, 50);
            this.Keyword_Box.Name = "Keyword_Box";
            this.Keyword_Box.Size = new System.Drawing.Size(334, 20);
            this.Keyword_Box.TabIndex = 1;
            this.Keyword_Box.WordWrap = false;
            // 
            // File_Button
            // 
            this.File_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.File_Button.CausesValidation = false;
            this.File_Button.Location = new System.Drawing.Point(362, 75);
            this.File_Button.Name = "File_Button";
            this.File_Button.Size = new System.Drawing.Size(32, 22);
            this.File_Button.TabIndex = 3;
            this.File_Button.Text = "...";
            this.File_Button.UseVisualStyleBackColor = true;
            this.File_Button.Click += new System.EventHandler(this.File_Button_Click);
            // 
            // File_Box
            // 
            this.File_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.File_Box.CausesValidation = false;
            this.File_Box.Enabled = false;
            this.File_Box.Location = new System.Drawing.Point(60, 76);
            this.File_Box.Name = "File_Box";
            this.File_Box.ReadOnly = true;
            this.File_Box.Size = new System.Drawing.Size(296, 20);
            this.File_Box.TabIndex = 3;
            this.File_Box.TabStop = false;
            // 
            // URL_Label
            // 
            this.URL_Label.AutoSize = true;
            this.URL_Label.Location = new System.Drawing.Point(6, 27);
            this.URL_Label.Name = "URL_Label";
            this.URL_Label.Size = new System.Drawing.Size(29, 13);
            this.URL_Label.TabIndex = 0;
            this.URL_Label.Text = "URL";
            // 
            // Keyword_Label
            // 
            this.Keyword_Label.AutoSize = true;
            this.Keyword_Label.Location = new System.Drawing.Point(6, 53);
            this.Keyword_Label.Name = "Keyword_Label";
            this.Keyword_Label.Size = new System.Drawing.Size(48, 13);
            this.Keyword_Label.TabIndex = 1;
            this.Keyword_Label.Text = "Keyword";
            // 
            // Start_Button
            // 
            this.Start_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Start_Button.Location = new System.Drawing.Point(256, 286);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(75, 23);
            this.Start_Button.TabIndex = 4;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Stop_Button
            // 
            this.Stop_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop_Button.Location = new System.Drawing.Point(337, 286);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(75, 23);
            this.Stop_Button.TabIndex = 4;
            this.Stop_Button.Text = "Stop";
            this.Stop_Button.UseVisualStyleBackColor = true;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // File_Dialog
            // 
            this.File_Dialog.FileName = "Sound";
            this.File_Dialog.Filter = "All files|*.*";
            this.File_Dialog.RestoreDirectory = true;
            this.File_Dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.File_Dialog_FileOk);
            // 
            // TaskListView
            // 
            this.TaskListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskListView.CausesValidation = false;
            this.TaskListView.CheckBoxes = true;
            this.TaskListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Column_URL,
            Column_Keywords,
            Column_File,
            this.Column_Status});
            this.TaskListView.GridLines = true;
            this.TaskListView.HideSelection = false;
            this.TaskListView.Location = new System.Drawing.Point(12, 154);
            this.TaskListView.MultiSelect = false;
            this.TaskListView.Name = "TaskListView";
            this.TaskListView.Size = new System.Drawing.Size(400, 126);
            this.TaskListView.TabIndex = 5;
            this.TaskListView.UseCompatibleStateImageBehavior = false;
            this.TaskListView.View = System.Windows.Forms.View.Details;
            this.TaskListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.TaskListView_ItemChecked);
            // 
            // Column_Status
            // 
            this.Column_Status.Text = "Status";
            // 
            // Remove_Button
            // 
            this.Remove_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Remove_Button.Location = new System.Drawing.Point(12, 286);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(75, 23);
            this.Remove_Button.TabIndex = 7;
            this.Remove_Button.Text = "Remove";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // TrayIcon
            // 
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "NotifieRSS";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // NotifieRss_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(424, 321);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(Add_Group);
            this.Controls.Add(this.TaskListView);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.Start_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(440, 360);
            this.Name = "NotifieRss_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "NotifieRSS";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotifieRss_Form_FormClosing);
            this.Resize += new System.EventHandler(this.NotifieRss_Form_Resize);
            Add_Group.ResumeLayout(false);
            Add_Group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox URL_Box;
        private System.Windows.Forms.Label URL_Label;
        private System.Windows.Forms.Label Keyword_Label;
        private System.Windows.Forms.TextBox Keyword_Box;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.OpenFileDialog File_Dialog;
        private System.Windows.Forms.Button File_Button;
        private System.Windows.Forms.TextBox File_Box;
        private System.Windows.Forms.ListView TaskListView;
        private System.Windows.Forms.Label File_Label;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.ColumnHeader Column_Status;
        private System.Windows.Forms.CheckBox Autostart_Checkbox;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.NotifyIcon TrayIcon;
    }
}

