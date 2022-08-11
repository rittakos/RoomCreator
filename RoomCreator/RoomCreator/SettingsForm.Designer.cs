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
            ((System.ComponentModel.ISupportInitialize)(this.width_numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(501, 307);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(148, 42);
            this.OK_button.TabIndex = 0;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // width_numericUpDown1
            // 
            this.width_numericUpDown1.Location = new System.Drawing.Point(74, 23);
            this.width_numericUpDown1.Name = "width_numericUpDown1";
            this.width_numericUpDown1.Size = new System.Drawing.Size(150, 29);
            this.width_numericUpDown1.TabIndex = 1;
            this.width_numericUpDown1.ValueChanged += new System.EventHandler(this.width_numericUpDown1_ValueChanged);
            // 
            // height_numericUpDown
            // 
            this.height_numericUpDown.Location = new System.Drawing.Point(71, 72);
            this.height_numericUpDown.Name = "height_numericUpDown";
            this.height_numericUpDown.Size = new System.Drawing.Size(150, 29);
            this.height_numericUpDown.TabIndex = 2;
            this.height_numericUpDown.ValueChanged += new System.EventHandler(this.height_numericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(71, 307);
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
            this.reward_comboBox.Location = new System.Drawing.Point(423, 25);
            this.reward_comboBox.Name = "reward_comboBox";
            this.reward_comboBox.Size = new System.Drawing.Size(151, 29);
            this.reward_comboBox.TabIndex = 8;
            this.reward_comboBox.SelectedIndexChanged += new System.EventHandler(this.reward_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Room Reward";
            // 
            // createFolder_checkBox
            // 
            this.createFolder_checkBox.AutoSize = true;
            this.createFolder_checkBox.Location = new System.Drawing.Point(269, 249);
            this.createFolder_checkBox.Name = "createFolder_checkBox";
            this.createFolder_checkBox.Size = new System.Drawing.Size(195, 25);
            this.createFolder_checkBox.TabIndex = 10;
            this.createFolder_checkBox.Text = "CreateFolderWhenSave";
            this.createFolder_checkBox.UseVisualStyleBackColor = true;
            this.createFolder_checkBox.CheckedChanged += new System.EventHandler(this.createFolder_checkBox_CheckedChanged);
            // 
            // description_textBox
            // 
            this.description_textBox.Location = new System.Drawing.Point(353, 164);
            this.description_textBox.Multiline = true;
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description_textBox.Size = new System.Drawing.Size(435, 36);
            this.description_textBox.TabIndex = 11;
            this.description_textBox.TextChanged += new System.EventHandler(this.description_textBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Description";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(423, 72);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(125, 29);
            this.name_textBox.TabIndex = 13;
            this.name_textBox.TextChanged += new System.EventHandler(this.name_textBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Name";
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(421, 114);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(125, 29);
            this.ID_textBox.TabIndex = 15;
            this.ID_textBox.TextChanged += new System.EventHandler(this.ID_textBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}