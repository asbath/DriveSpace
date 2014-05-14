namespace DriveSpace
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupDirs = new System.Windows.Forms.GroupBox();
            this.listDirectories = new System.Windows.Forms.ListBox();
            this.btnDirDelete = new System.Windows.Forms.Button();
            this.btnDirUpdate = new System.Windows.Forms.Button();
            this.btnDirAdd = new System.Windows.Forms.Button();
            this.groupDriveInfo = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtDirSpace = new System.Windows.Forms.TextBox();
            this.txtDriveLetter = new System.Windows.Forms.TextBox();
            this.lblDriveSpace = new System.Windows.Forms.Label();
            this.lblDirSpace = new System.Windows.Forms.Label();
            this.lblDriveLetter = new System.Windows.Forms.Label();
            this.lblDriveFullPercent = new System.Windows.Forms.Label();
            this.barDriveFull = new System.Windows.Forms.ProgressBar();
            this.groupDirInfo = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.popupDirectoryAdd = new System.Windows.Forms.FolderBrowserDialog();
            this.popupDirectoryUpdate = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.groupDirs.SuspendLayout();
            this.groupDriveInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDirectoryToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newDirectoryToolStripMenuItem
            // 
            this.newDirectoryToolStripMenuItem.Name = "newDirectoryToolStripMenuItem";
            this.newDirectoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newDirectoryToolStripMenuItem.Text = "New Directory";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateDirectoryToolStripMenuItem,
            this.toolStripSeparator3,
            this.deleteDirectoryToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // updateDirectoryToolStripMenuItem
            // 
            this.updateDirectoryToolStripMenuItem.Name = "updateDirectoryToolStripMenuItem";
            this.updateDirectoryToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.updateDirectoryToolStripMenuItem.Text = "Update Directory";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(160, 6);
            // 
            // deleteDirectoryToolStripMenuItem
            // 
            this.deleteDirectoryToolStripMenuItem.Name = "deleteDirectoryToolStripMenuItem";
            this.deleteDirectoryToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deleteDirectoryToolStripMenuItem.Text = "Delete Directory";
            // 
            // groupDirs
            // 
            this.groupDirs.Controls.Add(this.listDirectories);
            this.groupDirs.Controls.Add(this.btnDirDelete);
            this.groupDirs.Controls.Add(this.btnDirUpdate);
            this.groupDirs.Controls.Add(this.btnDirAdd);
            this.groupDirs.Location = new System.Drawing.Point(12, 27);
            this.groupDirs.Name = "groupDirs";
            this.groupDirs.Size = new System.Drawing.Size(415, 179);
            this.groupDirs.TabIndex = 1;
            this.groupDirs.TabStop = false;
            this.groupDirs.Text = "Directories";
            // 
            // listDirectories
            // 
            this.listDirectories.FormattingEnabled = true;
            this.listDirectories.Location = new System.Drawing.Point(89, 20);
            this.listDirectories.Name = "listDirectories";
            this.listDirectories.Size = new System.Drawing.Size(320, 147);
            this.listDirectories.TabIndex = 3;
            // 
            // btnDirDelete
            // 
            this.btnDirDelete.Location = new System.Drawing.Point(7, 80);
            this.btnDirDelete.Name = "btnDirDelete";
            this.btnDirDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDirDelete.TabIndex = 2;
            this.btnDirDelete.Text = "Delete";
            this.btnDirDelete.UseVisualStyleBackColor = true;
            // 
            // btnDirUpdate
            // 
            this.btnDirUpdate.Location = new System.Drawing.Point(7, 50);
            this.btnDirUpdate.Name = "btnDirUpdate";
            this.btnDirUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnDirUpdate.TabIndex = 1;
            this.btnDirUpdate.Text = "Update";
            this.btnDirUpdate.UseVisualStyleBackColor = true;
            this.btnDirUpdate.Click += new System.EventHandler(this.btnDirUpdate_Click);
            // 
            // btnDirAdd
            // 
            this.btnDirAdd.Location = new System.Drawing.Point(7, 20);
            this.btnDirAdd.Name = "btnDirAdd";
            this.btnDirAdd.Size = new System.Drawing.Size(75, 23);
            this.btnDirAdd.TabIndex = 0;
            this.btnDirAdd.Text = "Add";
            this.btnDirAdd.UseVisualStyleBackColor = true;
            this.btnDirAdd.Click += new System.EventHandler(this.btnDirAdd_Click);
            // 
            // groupDriveInfo
            // 
            this.groupDriveInfo.Controls.Add(this.textBox3);
            this.groupDriveInfo.Controls.Add(this.txtDirSpace);
            this.groupDriveInfo.Controls.Add(this.txtDriveLetter);
            this.groupDriveInfo.Controls.Add(this.lblDriveSpace);
            this.groupDriveInfo.Controls.Add(this.lblDirSpace);
            this.groupDriveInfo.Controls.Add(this.lblDriveLetter);
            this.groupDriveInfo.Controls.Add(this.lblDriveFullPercent);
            this.groupDriveInfo.Controls.Add(this.barDriveFull);
            this.groupDriveInfo.Location = new System.Drawing.Point(445, 28);
            this.groupDriveInfo.Name = "groupDriveInfo";
            this.groupDriveInfo.Size = new System.Drawing.Size(405, 178);
            this.groupDriveInfo.TabIndex = 2;
            this.groupDriveInfo.TabStop = false;
            this.groupDriveInfo.Text = "Drive Info";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(98, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // txtDirSpace
            // 
            this.txtDirSpace.Location = new System.Drawing.Point(98, 80);
            this.txtDirSpace.Name = "txtDirSpace";
            this.txtDirSpace.Size = new System.Drawing.Size(100, 20);
            this.txtDirSpace.TabIndex = 6;
            // 
            // txtDriveLetter
            // 
            this.txtDriveLetter.Location = new System.Drawing.Point(99, 29);
            this.txtDriveLetter.Name = "txtDriveLetter";
            this.txtDriveLetter.Size = new System.Drawing.Size(100, 20);
            this.txtDriveLetter.TabIndex = 5;
            // 
            // lblDriveSpace
            // 
            this.lblDriveSpace.AutoSize = true;
            this.lblDriveSpace.Location = new System.Drawing.Point(7, 57);
            this.lblDriveSpace.Name = "lblDriveSpace";
            this.lblDriveSpace.Size = new System.Drawing.Size(66, 13);
            this.lblDriveSpace.TabIndex = 4;
            this.lblDriveSpace.Text = "Drive Space";
            // 
            // lblDirSpace
            // 
            this.lblDirSpace.AutoSize = true;
            this.lblDirSpace.Location = new System.Drawing.Point(6, 84);
            this.lblDirSpace.Name = "lblDirSpace";
            this.lblDirSpace.Size = new System.Drawing.Size(83, 13);
            this.lblDirSpace.TabIndex = 3;
            this.lblDirSpace.Text = "Directory Space";
            // 
            // lblDriveLetter
            // 
            this.lblDriveLetter.AutoSize = true;
            this.lblDriveLetter.Location = new System.Drawing.Point(7, 28);
            this.lblDriveLetter.Name = "lblDriveLetter";
            this.lblDriveLetter.Size = new System.Drawing.Size(32, 13);
            this.lblDriveLetter.TabIndex = 2;
            this.lblDriveLetter.Text = "Drive";
            // 
            // lblDriveFullPercent
            // 
            this.lblDriveFullPercent.AutoSize = true;
            this.lblDriveFullPercent.Location = new System.Drawing.Point(330, 153);
            this.lblDriveFullPercent.Name = "lblDriveFullPercent";
            this.lblDriveFullPercent.Size = new System.Drawing.Size(15, 13);
            this.lblDriveFullPercent.TabIndex = 1;
            this.lblDriveFullPercent.Text = "%";
            // 
            // barDriveFull
            // 
            this.barDriveFull.Location = new System.Drawing.Point(315, 29);
            this.barDriveFull.Name = "barDriveFull";
            this.barDriveFull.Size = new System.Drawing.Size(45, 119);
            this.barDriveFull.TabIndex = 0;
            // 
            // groupDirInfo
            // 
            this.groupDirInfo.Location = new System.Drawing.Point(12, 213);
            this.groupDirInfo.Name = "groupDirInfo";
            this.groupDirInfo.Size = new System.Drawing.Size(760, 180);
            this.groupDirInfo.TabIndex = 3;
            this.groupDirInfo.TabStop = false;
            this.groupDirInfo.Text = "Directory Info";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(778, 341);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(778, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 405);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupDirInfo);
            this.Controls.Add(this.groupDriveInfo);
            this.Controls.Add(this.groupDirs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupDirs.ResumeLayout(false);
            this.groupDriveInfo.ResumeLayout(false);
            this.groupDriveInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupDirs;
        private System.Windows.Forms.GroupBox groupDriveInfo;
        private System.Windows.Forms.ListBox listDirectories;
        private System.Windows.Forms.Button btnDirDelete;
        private System.Windows.Forms.Button btnDirUpdate;
        private System.Windows.Forms.Button btnDirAdd;
        private System.Windows.Forms.ProgressBar barDriveFull;
        private System.Windows.Forms.Label lblDriveFullPercent;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtDirSpace;
        private System.Windows.Forms.TextBox txtDriveLetter;
        private System.Windows.Forms.Label lblDriveSpace;
        private System.Windows.Forms.Label lblDirSpace;
        private System.Windows.Forms.Label lblDriveLetter;
        private System.Windows.Forms.GroupBox groupDirInfo;
        private System.Windows.Forms.ToolStripMenuItem newDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem deleteDirectoryToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.FolderBrowserDialog popupDirectoryAdd;
        private System.Windows.Forms.FolderBrowserDialog popupDirectoryUpdate;
    }
}

