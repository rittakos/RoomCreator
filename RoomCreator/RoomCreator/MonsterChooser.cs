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
    public partial class MonsterChooser : Form
    {
        readonly Monster? monster;
        public  MonsterChooser()
        {
            InitializeComponent();
        }

        public MonsterChooser(ref Monster m)
        {
            InitializeComponent();
            this.monster = m;
            int i = (int)m.Type;
            monsterType_comboBox.DataSource = Enum.GetValues(typeof(MonsterType));
            monsterType_comboBox.SelectedIndex = i;
        }

        private void monsterType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (monster == null)
                throw new NullReferenceException();
            monster.Type = (MonsterType)monsterType_comboBox.SelectedItem;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void monsterType_comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                DialogResult = DialogResult.Cancel;
            else if(e.KeyCode == Keys.Enter)
                DialogResult = DialogResult.OK;
            else
                return;
            Close();
        }
    }
}
