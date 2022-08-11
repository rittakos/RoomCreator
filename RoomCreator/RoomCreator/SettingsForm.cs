using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomCreator
{
    public partial class SettingsForm : Form
    {
        Room room;
        Room tempRoom;
        public SettingsForm()
        {
            InitializeComponent();
        }

        public SettingsForm(ref Room room)
        {
            InitializeComponent();
            this.room = room;
            tempRoom = (Room)this.room.Clone();

            LoadValues();
        }
        
        private void LoadValues()
        {
            name_textBox.Text               = room.Name;
            ID_textBox.Text                 = room.ID.ToString();
            description_textBox.Text        = room.Description;

            width_numericUpDown1.Value      = room.Width;
            height_numericUpDown.Value      = room.Height;

            reward_comboBox.DataSource      = Enum.GetValues(typeof(RewardType));
            reward_comboBox.SelectedIndex   = (int)room.RoomReward;

            level_numericUpDown.Value       = room.Level;

            createFolder_checkBox.Checked   = room.SaveData.CreateFolder;
        }


        //Event Handlers
        private void OK_button_Click(object sender, EventArgs e)
        {
            this.room.Name          = tempRoom.Name;
            this.room.ID            = tempRoom.ID;
            this.room.Description   = tempRoom.Description;
            this.room.Height        = tempRoom.Height;
            this.room.Width         = tempRoom.Width;
            this.room.SaveData      = tempRoom.SaveData;
            this.room.RoomReward    = tempRoom.RoomReward;
            this.room.Level         = tempRoom.Level;
            this.DialogResult       = DialogResult.OK;
            this.Close();
        }
        private void width_numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tempRoom.Width = Convert.ToInt32(width_numericUpDown1.Value);
        }
        private void height_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            tempRoom.Height = Convert.ToInt32(height_numericUpDown.Value);
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void reward_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<RewardType>(reward_comboBox.SelectedValue.ToString(), out RewardType reward);
            tempRoom.RoomReward = reward;
        }
        private void createFolder_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            tempRoom.SaveData.CreateFolder = createFolder_checkBox.Checked;
        }
        private void description_textBox_TextChanged(object sender, EventArgs e)
        {
            tempRoom.Description = description_textBox.Text;
        }

        private void name_textBox_TextChanged(object sender, EventArgs e)
        {
            tempRoom.Name = name_textBox.Text;
        }

        private void ID_textBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ID_textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                ID_textBox.Text = ID_textBox.Text.Remove(ID_textBox.Text.Length - 1);
            }else if(ID_textBox.Text != "")
                tempRoom.ID = Convert.ToInt32(ID_textBox.Text);
        }

        private void level_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            tempRoom.Level = (int)level_numericUpDown.Value;
        }
    }
}
