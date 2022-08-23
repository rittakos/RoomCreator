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
    public partial class RewardChooserForm : Form
    {
        Reward reward;

        public RewardChooserForm()
        {
            InitializeComponent();
        }
        public RewardChooserForm(ref Reward r)
        {
            InitializeComponent();
            reward = r;
            int i = (int)r.Type;
            rewardType_comboBox.DataSource = Enum.GetValues(typeof(RewardType));
            rewardType_comboBox.SelectedIndex = i;
        }

        private void rewardType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.reward.Type = (RewardType)rewardType_comboBox.SelectedItem;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void rewardType_comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                DialogResult = DialogResult.Cancel;
            else if (e.KeyCode == Keys.Enter)
                DialogResult = DialogResult.OK;
            else
                return;
            this.Close();
        }


        private void RewardChooserForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void RewardChooserForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void rewardType_comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        
    }
}
