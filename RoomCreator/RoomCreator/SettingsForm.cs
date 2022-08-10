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
            width_numericUpDown1.Value = room.Width;
            height_numericUpDown.Value = room.Height;
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            this.room.Height = tempRoom.Height;
            this.room.Width = tempRoom.Width;
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
    }
}
