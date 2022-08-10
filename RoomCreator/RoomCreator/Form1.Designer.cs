namespace RoomCreator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.settings_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settings_menuStrip = new System.Windows.Forms.MenuStrip();
            this.sizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.settings_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings_contextMenuStrip
            // 
            this.settings_contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.settings_contextMenuStrip.Name = "settings_contextMenuStrip";
            this.settings_contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // settings_menuStrip
            // 
            this.settings_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.settings_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem1,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.settings_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.settings_menuStrip.Name = "settings_menuStrip";
            this.settings_menuStrip.Size = new System.Drawing.Size(800, 29);
            this.settings_menuStrip.TabIndex = 1;
            this.settings_menuStrip.Text = "menuStrip1";
            // 
            // sizeToolStripMenuItem1
            // 
            this.sizeToolStripMenuItem1.Name = "sizeToolStripMenuItem1";
            this.sizeToolStripMenuItem1.Size = new System.Drawing.Size(80, 25);
            this.sizeToolStripMenuItem1.Text = "Settings";
            this.sizeToolStripMenuItem1.Click += new System.EventHandler(this.sizeToolStripMenuItem1_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(57, 25);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "room";
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "room files (*.room)|*.room|All files (*.*)|*.*";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.settings_menuStrip);
            this.MainMenuStrip = this.settings_menuStrip;
            this.Name = "Form1";
            this.Text = "Room Creator";
            this.settings_menuStrip.ResumeLayout(false);
            this.settings_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip settings_contextMenuStrip;
        private MenuStrip settings_menuStrip;
        private ToolStripMenuItem sizeToolStripMenuItem1;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}