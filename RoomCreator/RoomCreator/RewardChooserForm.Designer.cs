namespace RoomCreator
{
    partial class RewardChooserForm
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
            this.rewardType_comboBox = new System.Windows.Forms.ComboBox();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rewardType_comboBox
            // 
            this.rewardType_comboBox.FormattingEnabled = true;
            this.rewardType_comboBox.Location = new System.Drawing.Point(130, 43);
            this.rewardType_comboBox.Name = "rewardType_comboBox";
            this.rewardType_comboBox.Size = new System.Drawing.Size(310, 29);
            this.rewardType_comboBox.TabIndex = 0;
            this.rewardType_comboBox.SelectedIndexChanged += new System.EventHandler(this.rewardType_comboBox_SelectedIndexChanged);
            this.rewardType_comboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rewardType_comboBox_KeyDown);
            this.rewardType_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rewardType_comboBox_KeyPress);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(356, 118);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(94, 29);
            this.ok_button.TabIndex = 1;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(110, 118);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(94, 29);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // RewardChooserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 205);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.rewardType_comboBox);
            this.Name = "RewardChooserForm";
            this.Text = "RewardChooserForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RewardChooserForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RewardChooserForm_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox rewardType_comboBox;
        private Button ok_button;
        private Button cancel_button;
    }
}