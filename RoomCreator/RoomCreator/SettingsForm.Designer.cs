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
            this.monster_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.width_numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(317, 252);
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
            // monster_button
            // 
            this.monster_button.Location = new System.Drawing.Point(48, 150);
            this.monster_button.Name = "monster_button";
            this.monster_button.Size = new System.Drawing.Size(94, 29);
            this.monster_button.TabIndex = 5;
            this.monster_button.Text = "Monsters";
            this.monster_button.UseVisualStyleBackColor = true;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(155, 248);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(94, 29);
            this.cancel_button.TabIndex = 6;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.monster_button);
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
        private Button monster_button;
        private Button cancel_button;
    }
}