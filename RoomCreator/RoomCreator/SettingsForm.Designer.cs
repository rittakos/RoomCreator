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
            this.label10.Location = new System.Drawing.Point(444, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Monster file name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(447, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Reward file name";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}