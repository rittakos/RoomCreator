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
            this.monsterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settings_menuStrip = new System.Windows.Forms.MenuStrip();
            this.sizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cellType_radioButton = new System.Windows.Forms.RadioButton();
            this.monster_radioButton = new System.Windows.Forms.RadioButton();
            this.reward_radioButton = new System.Windows.Forms.RadioButton();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settings_contextMenuStrip.SuspendLayout();
            this.settings_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings_contextMenuStrip
            // 
            this.settings_contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.settings_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monsterToolStripMenuItem,
            this.itemToolStripMenuItem});
            this.settings_contextMenuStrip.Name = "settings_contextMenuStrip";
            this.settings_contextMenuStrip.Size = new System.Drawing.Size(139, 56);
            // 
            // monsterToolStripMenuItem
            // 
            this.monsterToolStripMenuItem.Name = "monsterToolStripMenuItem";
            this.monsterToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.monsterToolStripMenuItem.Text = "monster";
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.itemToolStripMenuItem.Text = "item";
            // 
            // settings_menuStrip
            // 
            this.settings_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.settings_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem1,
            this.generateToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.helpToolStripMenuItem});
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
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "rm";
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "room files (*.rm)|*.rm|All files (*.*)|*.*";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "rm";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // cellType_radioButton
            // 
            this.cellType_radioButton.AutoSize = true;
            this.cellType_radioButton.Location = new System.Drawing.Point(12, 32);
            this.cellType_radioButton.Name = "cellType_radioButton";
            this.cellType_radioButton.Size = new System.Drawing.Size(93, 25);
            this.cellType_radioButton.TabIndex = 2;
            this.cellType_radioButton.TabStop = true;
            this.cellType_radioButton.Text = "Cell Type";
            this.cellType_radioButton.UseVisualStyleBackColor = true;
            // 
            // monster_radioButton
            // 
            this.monster_radioButton.AutoSize = true;
            this.monster_radioButton.Location = new System.Drawing.Point(111, 32);
            this.monster_radioButton.Name = "monster_radioButton";
            this.monster_radioButton.Size = new System.Drawing.Size(89, 25);
            this.monster_radioButton.TabIndex = 3;
            this.monster_radioButton.TabStop = true;
            this.monster_radioButton.Text = "Monster";
            this.monster_radioButton.UseVisualStyleBackColor = true;
            // 
            // reward_radioButton
            // 
            this.reward_radioButton.AutoSize = true;
            this.reward_radioButton.Location = new System.Drawing.Point(206, 32);
            this.reward_radioButton.Name = "reward_radioButton";
            this.reward_radioButton.Size = new System.Drawing.Size(91, 25);
            this.reward_radioButton.TabIndex = 4;
            this.reward_radioButton.TabStop = true;
            this.reward_radioButton.Text = "Rewards";
            this.reward_radioButton.UseVisualStyleBackColor = true;
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.generateToolStripMenuItem.Text = "Generate";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reward_radioButton);
            this.Controls.Add(this.monster_radioButton);
            this.Controls.Add(this.cellType_radioButton);
            this.Controls.Add(this.settings_menuStrip);
            this.MainMenuStrip = this.settings_menuStrip;
            this.Name = "Form1";
            this.Text = "Room Creator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.settings_contextMenuStrip.ResumeLayout(false);
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
        private ToolStripMenuItem monsterToolStripMenuItem;
        private ToolStripMenuItem itemToolStripMenuItem;
        private FolderBrowserDialog folderBrowserDialog1;
        private RadioButton cellType_radioButton;
        private RadioButton monster_radioButton;
        private RadioButton reward_radioButton;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem generateToolStripMenuItem;
    }
}