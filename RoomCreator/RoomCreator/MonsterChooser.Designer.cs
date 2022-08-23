namespace RoomCreator
{
    partial class MonsterChooser
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
            this.monsterType_comboBox = new System.Windows.Forms.ComboBox();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monsterType_comboBox
            // 
            this.monsterType_comboBox.FormattingEnabled = true;
            this.monsterType_comboBox.Location = new System.Drawing.Point(146, 53);
            this.monsterType_comboBox.Name = "monsterType_comboBox";
            this.monsterType_comboBox.Size = new System.Drawing.Size(249, 29);
            this.monsterType_comboBox.TabIndex = 0;
            this.monsterType_comboBox.SelectedIndexChanged += new System.EventHandler(this.monsterType_comboBox_SelectedIndexChanged);
            this.monsterType_comboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.monsterType_comboBox_KeyDown);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(363, 110);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(94, 29);
            this.ok_button.TabIndex = 1;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(105, 110);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(94, 29);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // MonsterChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 171);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.monsterType_comboBox);
            this.Name = "MonsterChooser";
            this.Text = "Choose Monster";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox monsterType_comboBox;
        private Button ok_button;
        private Button cancel_button;
    }
}