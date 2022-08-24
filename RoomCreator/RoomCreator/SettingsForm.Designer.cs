namespace RoomCreator
{
    partial class SettingsForm
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
            this.OK_button = new System.Windows.Forms.Button();
            this.width_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.height_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.reward_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createFolder_checkBox = new System.Windows.Forms.CheckBox();
            this.description_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.level_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.folderName_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.monsterFile_textBox = new System.Windows.Forms.TextBox();
            this.rewardFile_textBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.upWall_checkBox = new System.Windows.Forms.CheckBox();
            this.downWall_checkBox = new System.Windows.Forms.CheckBox();
            this.leftWall_checkBox = new System.Windows.Forms.CheckBox();
            this.rightWall_checkBox = new System.Windows.Forms.CheckBox();
            this.isWall_checkBox = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.rebuild_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.width_numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(640, 396);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(148, 42);
            this.OK_button.TabIndex = 0;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // width_numericUpDown1
            // 
            this.width_numericUpDown1.Location = new System.Drawing.Point(640, 113);
            this.width_numericUpDown1.Name = "width_numericUpDown1";
            this.width_numericUpDown1.Size = new System.Drawing.Size(59, 29);
            this.width_numericUpDown1.TabIndex = 1;
            this.width_numericUpDown1.ValueChanged += new System.EventHandler(this.width_numericUpDown1_ValueChanged);
            // 
            // height_numericUpDown
            // 
            this.height_numericUpDown.Location = new System.Drawing.Point(640, 164);
            this.height_numericUpDown.Name = "height_numericUpDown";
            this.height_numericUpDown.Size = new System.Drawing.Size(59, 29);
            this.height_numericUpDown.TabIndex = 2;
            this.height_numericUpDown.ValueChanged += new System.EventHandler(this.height_numericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(12, 396);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(148, 42);
            this.cancel_button.TabIndex = 6;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // reward_comboBox
            // 
            this.reward_comboBox.FormattingEnabled = true;
            this.reward_comboBox.Location = new System.Drawing.Point(373, 64);
            this.reward_comboBox.Name = "reward_comboBox";
            this.reward_comboBox.Size = new System.Drawing.Size(151, 29);
            this.reward_comboBox.TabIndex = 8;
            this.reward_comboBox.SelectedIndexChanged += new System.EventHandler(this.reward_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Room Reward";
            // 
            // createFolder_checkBox
            // 
            this.createFolder_checkBox.AutoSize = true;
            this.createFolder_checkBox.Location = new System.Drawing.Point(12, 321);
            this.createFolder_checkBox.Name = "createFolder_checkBox";
            this.createFolder_checkBox.Size = new System.Drawing.Size(210, 25);
            this.createFolder_checkBox.TabIndex = 10;
            this.createFolder_checkBox.Text = "Create Folder When Save:";
            this.createFolder_checkBox.UseVisualStyleBackColor = true;
            this.createFolder_checkBox.CheckedChanged += new System.EventHandler(this.createFolder_checkBox_CheckedChanged);
            // 
            // description_textBox
            // 
            this.description_textBox.Location = new System.Drawing.Point(12, 217);
            this.description_textBox.Multiline = true;
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description_textBox.Size = new System.Drawing.Size(776, 48);
            this.description_textBox.TabIndex = 11;
            this.description_textBox.TextChanged += new System.EventHandler(this.description_textBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Description";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(87, 64);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(125, 29);
            this.name_textBox.TabIndex = 13;
            this.name_textBox.TextChanged += new System.EventHandler(this.name_textBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Name";
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(87, 113);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(125, 29);
            this.ID_textBox.TabIndex = 15;
            this.ID_textBox.TextChanged += new System.EventHandler(this.ID_textBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID";
            // 
            // level_numericUpDown
            // 
            this.level_numericUpDown.Location = new System.Drawing.Point(640, 64);
            this.level_numericUpDown.Name = "level_numericUpDown";
            this.level_numericUpDown.Size = new System.Drawing.Size(59, 29);
            this.level_numericUpDown.TabIndex = 17;
            this.level_numericUpDown.ValueChanged += new System.EventHandler(this.level_numericUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Level";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 38);
            this.label8.TabIndex = 19;
            this.label8.Text = "Room Settings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(16, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 38);
            this.label9.TabIndex = 20;
            this.label9.Text = "File Settings";
            // 
            // folderName_textBox
            // 
            this.folderName_textBox.Location = new System.Drawing.Point(242, 319);
            this.folderName_textBox.Name = "folderName_textBox";
            this.folderName_textBox.PlaceholderText = "Room";
            this.folderName_textBox.Size = new System.Drawing.Size(125, 29);
            this.folderName_textBox.TabIndex = 21;
            this.folderName_textBox.TextChanged += new System.EventHandler(this.folderName_textBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(447, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Monster file name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(447, 347);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Reward file name";
            // 
            // monsterFile_textBox
            // 
            this.monsterFile_textBox.Location = new System.Drawing.Point(589, 299);
            this.monsterFile_textBox.Name = "monsterFile_textBox";
            this.monsterFile_textBox.Size = new System.Drawing.Size(199, 29);
            this.monsterFile_textBox.TabIndex = 24;
            this.monsterFile_textBox.TextChanged += new System.EventHandler(this.monsterFile_textBox_TextChanged);
            // 
            // rewardFile_textBox
            // 
            this.rewardFile_textBox.Location = new System.Drawing.Point(589, 344);
            this.rewardFile_textBox.Name = "rewardFile_textBox";
            this.rewardFile_textBox.Size = new System.Drawing.Size(199, 29);
            this.rewardFile_textBox.TabIndex = 25;
            this.rewardFile_textBox.TextChanged += new System.EventHandler(this.rewardFile_textBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(258, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 21);
            this.label12.TabIndex = 26;
            this.label12.Text = "Walls:";
            // 
            // upWall_checkBox
            // 
            this.upWall_checkBox.AutoSize = true;
            this.upWall_checkBox.Location = new System.Drawing.Point(398, 116);
            this.upWall_checkBox.Name = "upWall_checkBox";
            this.upWall_checkBox.Size = new System.Drawing.Size(52, 25);
            this.upWall_checkBox.TabIndex = 27;
            this.upWall_checkBox.Text = "Up";
            this.upWall_checkBox.UseVisualStyleBackColor = true;
            this.upWall_checkBox.CheckedChanged += new System.EventHandler(this.upWall_checkBox_CheckedChanged);
            // 
            // downWall_checkBox
            // 
            this.downWall_checkBox.AutoSize = true;
            this.downWall_checkBox.Location = new System.Drawing.Point(398, 178);
            this.downWall_checkBox.Name = "downWall_checkBox";
            this.downWall_checkBox.Size = new System.Drawing.Size(73, 25);
            this.downWall_checkBox.TabIndex = 28;
            this.downWall_checkBox.Text = "Down";
            this.downWall_checkBox.UseVisualStyleBackColor = true;
            this.downWall_checkBox.CheckedChanged += new System.EventHandler(this.downWall_checkBox_CheckedChanged);
            // 
            // leftWall_checkBox
            // 
            this.leftWall_checkBox.AutoSize = true;
            this.leftWall_checkBox.Location = new System.Drawing.Point(343, 147);
            this.leftWall_checkBox.Name = "leftWall_checkBox";
            this.leftWall_checkBox.Size = new System.Drawing.Size(58, 25);
            this.leftWall_checkBox.TabIndex = 29;
            this.leftWall_checkBox.Text = "Left";
            this.leftWall_checkBox.UseVisualStyleBackColor = true;
            this.leftWall_checkBox.CheckedChanged += new System.EventHandler(this.leftWall_checkBox_CheckedChanged);
            // 
            // rightWall_checkBox
            // 
            this.rightWall_checkBox.AutoSize = true;
            this.rightWall_checkBox.Location = new System.Drawing.Point(455, 147);
            this.rightWall_checkBox.Name = "rightWall_checkBox";
            this.rightWall_checkBox.Size = new System.Drawing.Size(69, 25);
            this.rightWall_checkBox.TabIndex = 30;
            this.rightWall_checkBox.Text = "Right";
            this.rightWall_checkBox.UseVisualStyleBackColor = true;
            this.rightWall_checkBox.CheckedChanged += new System.EventHandler(this.rightWall_checkBox_CheckedChanged);
            // 
            // isWall_checkBox
            // 
            this.isWall_checkBox.AutoSize = true;
            this.isWall_checkBox.Location = new System.Drawing.Point(16, 162);
            this.isWall_checkBox.Name = "isWall_checkBox";
            this.isWall_checkBox.Size = new System.Drawing.Size(62, 25);
            this.isWall_checkBox.TabIndex = 31;
            this.isWall_checkBox.Text = "Wall";
            this.isWall_checkBox.UseVisualStyleBackColor = true;
            this.isWall_checkBox.CheckedChanged += new System.EventHandler(this.isWall_checkBox_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(729, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 21);
            this.linkLabel1.TabIndex = 32;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // rebuild_checkBox
            // 
            this.rebuild_checkBox.AutoSize = true;
            this.rebuild_checkBox.Location = new System.Drawing.Point(539, 406);
            this.rebuild_checkBox.Name = "rebuild_checkBox";
            this.rebuild_checkBox.Size = new System.Drawing.Size(85, 25);
            this.rebuild_checkBox.TabIndex = 33;
            this.rebuild_checkBox.Text = "Rebuild";
            this.rebuild_checkBox.UseVisualStyleBackColor = true;
            this.rebuild_checkBox.CheckedChanged += new System.EventHandler(this.rebuild_checkBox_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rebuild_checkBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.isWall_checkBox);
            this.Controls.Add(this.rightWall_checkBox);
            this.Controls.Add(this.leftWall_checkBox);
            this.Controls.Add(this.downWall_checkBox);
            this.Controls.Add(this.upWall_checkBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rewardFile_textBox);
            this.Controls.Add(this.monsterFile_textBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.folderName_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.level_numericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.description_textBox);
            this.Controls.Add(this.createFolder_checkBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reward_comboBox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.height_numericUpDown);
            this.Controls.Add(this.width_numericUpDown1);
            this.Controls.Add(this.OK_button);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.width_numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OK_button;
        private NumericUpDown width_numericUpDown1;
        private NumericUpDown height_numericUpDown;
        private Label label1;
        private Label label2;
        private Button cancel_button;
        private ComboBox reward_comboBox;
        private Label label3;
        private CheckBox createFolder_checkBox;
        private TextBox description_textBox;
        private Label label4;
        private TextBox name_textBox;
        private Label label5;
        private TextBox ID_textBox;
        private Label label6;
        private NumericUpDown level_numericUpDown;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox folderName_textBox;
        private Label label10;
        private Label label11;
        private TextBox monsterFile_textBox;
        private TextBox rewardFile_textBox;
        private Label label12;
        private CheckBox upWall_checkBox;
        private CheckBox downWall_checkBox;
        private CheckBox leftWall_checkBox;
        private CheckBox rightWall_checkBox;
        private CheckBox isWall_checkBox;
        private LinkLabel linkLabel1;
        private CheckBox rebuild_checkBox;
    }
}