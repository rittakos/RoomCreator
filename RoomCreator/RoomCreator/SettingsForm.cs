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

            isWall_checkBox.Checked         = room.IsWall;

            width_numericUpDown1.Value      = room.Width;
            height_numericUpDown.Value      = room.Height;

            reward_comboBox.DataSource      = Enum.GetValues(typeof(RoomRewardType));
            reward_comboBox.SelectedIndex   = (int)room.RoomReward;

            level_numericUpDown.Value       = room.Level;

            createFolder_checkBox.Checked   = room.SaveData.CreateFolder;
            folderName_textBox.Text         = room.SaveData.FolderName;

            leftWall_checkBox.Checked       = room.Wall.hasWall(Direction.Left);
            rightWall_checkBox.Checked      = room.Wall.hasWall(Direction.Right);
            upWall_checkBox.Checked         = room.Wall.hasWall(Direction.Up);
            downWall_checkBox.Checked       = room.Wall.hasWall(Direction.Down);
        }


        //Event Handlers
        private void OK_button_Click(object sender, EventArgs e)
        {
            this.room.Name          = tempRoom.Name;
            this.room.ID            = tempRoom.ID;
            this.room.Description   = tempRoom.Description;
            this.room.IsWall        = tempRoom.IsWall;
            this.room.Height        = tempRoom.Height;
            this.room.Width         = tempRoom.Width;
            this.room.SaveData      = tempRoom.SaveData;
            this.room.RoomReward    = tempRoom.RoomReward;
            this.room.Level         = tempRoom.Level;
            this.room.Wall          = tempRoom.Wall;
            this.room.NeedReset     = tempRoom.NeedReset;
            this.DialogResult       = DialogResult.OK;
            this.Close();
        }

        private void needReset()
        {
            tempRoom.NeedReset = true;
            rebuild_checkBox.Checked = true;
            rebuild_checkBox.Enabled = false;
        }

        private void width_numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int newWidth = Convert.ToInt32(width_numericUpDown1.Value);
            if (newWidth != tempRoom.Width)
            {
                tempRoom.Width = newWidth;
                needReset();
            }
        }
        private void height_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int newHeight = Convert.ToInt32(height_numericUpDown.Value);
            if (newHeight != tempRoom.Height)
            {
                tempRoom.Height = newHeight;
                needReset();
            }
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void reward_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<RoomRewardType>(reward_comboBox.SelectedValue.ToString(), out RoomRewardType reward);
            tempRoom.RoomReward = reward;
        }
        private void createFolder_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            tempRoom.SaveData.CreateFolder = createFolder_checkBox.Checked;
            folderName_textBox.Enabled = createFolder_checkBox.Checked;
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

        private void folderName_textBox_TextChanged(object sender, EventArgs e)
        {
            tempRoom.SaveData.FolderName = folderName_textBox.Text;
        }

        private void monsterFile_textBox_TextChanged(object sender, EventArgs e)
        {
            tempRoom.SaveData.MonsterFileName = monsterFile_textBox.Text;
        }

        private void rewardFile_textBox_TextChanged(object sender, EventArgs e)
        {
            tempRoom.SaveData.RewardFileName = rewardFile_textBox.Text;
        }

        private void upWall_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            tempRoom.Wall.setWall(Direction.Up, upWall_checkBox.Checked);
        }

        private void downWall_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            tempRoom.Wall.setWall(Direction.Down, downWall_checkBox.Checked);
        }

        private void leftWall_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            tempRoom.Wall.setWall(Direction.Left, leftWall_checkBox.Checked);
        }

        private void rightWall_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            tempRoom.Wall.setWall(Direction.Right, rightWall_checkBox.Checked);
        }

        private void isWall_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            tempRoom.IsWall = isWall_checkBox.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = @"https://github.com/rittakos/RoomCreator", UseShellExecute = true });
        }

        private void rebuild_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            tempRoom.NeedReset = rebuild_checkBox.Checked;
            if(tempRoom.NeedReset)
                OK_button.BackColor = Color.Red;
            else
                OK_button.BackColor = Color.White;
        }
    }
}
