using RoomCreator;

namespace RoomCreator
{
    public partial class Form1 : Form
    {
        private Room room;
        private Button[,] cells;
        private Font buttonTextFont = new Font("Arial", 10, FontStyle.Bold);
        public Form1()
        {
            InitializeComponent();
            room = new Room();

            cells = new Button[room.Width, room.Height];

            generateMap();
        }


        
        private Bitmap getButtonImage(Point coord)
        {
            Button button = cells[coord.X, coord.Y];
            Cell currentCell = room.getCell(coord);

            Bitmap bmp = new Bitmap(button.ClientRectangle.Width, button.ClientRectangle.Height);

            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.Clear(button.BackColor);
                using (Graphics gfx = Graphics.FromImage(bmp))
                using (SolidBrush brush = new SolidBrush(currentCell.getColor()))
                {
                    gfx.FillRectangle(brush, 0, 0, button.ClientRectangle.Width, button.ClientRectangle.Height);
                }

                StringFormat SF = new StringFormat();
                SF.Alignment = StringAlignment.Center;
                SF.LineAlignment = StringAlignment.Near;

                if(room.rewards.GetRewardOnCoord(coord) != null && room.rewards.GetRewardOnCoord(coord).Type != RewardType.None)
                {
                    using (Font arial = new Font("Arial", 8, FontStyle.Bold))
                    {
                        Rectangle RC = button.ClientRectangle;
                        RC.Inflate(-5, -1);
                        string toDisplay = Reward.getStringToDisplay(room.rewards.GetRewardOnCoord(coord).Type);
                        G.DrawString(toDisplay, arial, Brushes.Orange, RC, SF);
                    }
                }
                
                Brush textBrush = new SolidBrush(currentCell.getTextColor());

                string text = coord.X + " " + coord.Y;
                using (Font courier = new Font("MS Courier", 12))
                {
                    SF.LineAlignment = StringAlignment.Center;
                    G.DrawString(text, courier, textBrush, button.ClientRectangle, SF);
                }

                if (room.monsters.GetMonsterOnCoord(coord) != null && room.monsters.GetMonsterOnCoord(coord).Type != MonsterType.None)
                {
                    using (Font arial = new Font("Arial", 9, FontStyle.Bold))
                    {
                        Rectangle RC = button.ClientRectangle;
                        RC.X = 0;
                        RC.Y = 15;
                        string toDisplay = Monster.getStringToDisplay(room.monsters.GetMonsterOnCoord(coord).Type);
                        G.DrawString(toDisplay, arial, Brushes.Red, RC, SF);
                    }
                }
            }

            return bmp;
        }
        private Point getButtonIndex(Button button)
        {
            for (int row = 0; row < room.Height; ++row)
            {
                for (int col = 0; col < room.Width; ++col)
                {
                    if (cells[row, col] == button)
                        return new Point(row, col);
                }
            }
            return new Point(-1, -1);
        }
        private void reset(bool resetRoom)
        {
            if(resetRoom)
                room.resetRoom();

            foreach (Button b in cells)
            {
                this.Controls.Remove(b);
            }

            cells = new Button[room.Height, room.Width];
        }
        private void generateMap()
        {
            Point start = new Point(3, 70);
            Size buttonSize = new Size(50, 50);

            for (int row = 0; row < room.Height; ++row)
            {
                for(int col = 0; col < room.Width; ++col)
                {
                    Point coord = new Point (row, col);
                    Cell currnetCell = room.getCell(coord);

                    Button newButton = new Button();
                    this.Controls.Add(newButton);

                    //newButton.Text =  getButtonText(coord);
                    //newButton.Font = buttonTextFont;
                    newButton.Location = new Point(col * buttonSize.Width + start.X, row * buttonSize.Height + start.Y);
                    newButton.Size = new Size(50, 50);
                    //newButton.BackColor = currnetCell.getColor();


                    //newButton.Text = "";
                    
               


                    newButton.Click += new EventHandler(leftClick);

                    newButton.MouseDown += new MouseEventHandler(rightClick);
                    newButton.MouseDoubleClick += new MouseEventHandler(doubleClick);
                    //newButton.Click += new EventHandler(leftClick);

                    cells[row, col] = newButton;

                    newButton.Image = getButtonImage(coord);
                    newButton.ImageAlign = ContentAlignment.MiddleCenter;
                    //newButton.ForeColor = getButtonTextColor(coord);
                }
            }
            Size = new Size(room.Width * buttonSize.Width + 23, room.Height * buttonSize.Height + 120);
        }


        //Event handlers
        private void leftClick(object sender, EventArgs e)
        {
            Button button = ((Button)sender);
            Point coord = getButtonIndex(button);

            if (cellType_radioButton.Checked)
                room.changeCellType(coord);
            else if (monster_radioButton.Checked)
            {
                MonsterType type = MonsterType.None;
                if(room.monsters.GetMonsterOnCoord(coord) != null)
                    type = room.monsters.GetMonsterOnCoord(coord).Type;

                Monster m = new Monster(type, coord);
                m.Type = type;

                Form settings = new MonsterChooser(ref m);
                DialogResult result = settings.ShowDialog();

                if(result == DialogResult.OK)
                    room.monsters.changeMonster(coord, m.Type);
            }
            else if (reward_radioButton.Checked)
            {
                RewardType type = RewardType.None;

                if (room.rewards.GetRewardOnCoord(coord) != null)
                    type = room.rewards.GetRewardOnCoord(coord).Type;

                Reward r = new Reward(type, coord);
                r.Type = type;

                Form settings = new RewardChooserForm(ref r);
                DialogResult result = settings.ShowDialog();

                if (result == DialogResult.OK)
                    room.rewards.changeReward(coord, (RewardType)r.Type);
            }

            //button.BackColor    = room.getCell(coord).getColor();
            //button.ForeColor    = getButtonTextColor(coord);
            //button.Text         = getButtonText(coord);
            button.Image = getButtonImage(coord);
            button.ImageAlign = ContentAlignment.MiddleCenter;
        }
        private void sizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form settings = new SettingsForm(ref room);
            DialogResult result = settings.ShowDialog();

            if (result == DialogResult.OK)
            {
                reset(room.NeedReset);
                generateMap();
            }
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DialogResult result = openFileDialog.ShowDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                reset(true);
                room.load(openFileDialog.FileName);
                generateMap();
            }

        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DialogResult result = folderBrowserDialog1.ShowDialog();
            //if (result == DialogResult.OK)
            //    room.save(folderBrowserDialog1.SelectedPath);
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                room.save(saveFileDialog.FileName);
        }
        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            room.load(openFileDialog.FileName);
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = @"https://github.com/rittakos/RoomCreator#readme", UseShellExecute = true });
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generator generator = new Generator();
            Form generatorForm = new GeneratorForm(ref generator);
            DialogResult result = generatorForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                generator.Generate();
            }
        }





        //Unused methods
        private void rightClick(object sender, MouseEventArgs e)
        {
            //if(e.Button == MouseButtons.Right)
            //{
            //    Control ctrl = ((Control)sender);
            //    Point coord = getButtonIndex((Button)sender);

            //    room.changeMonster(coord.X, coord.Y); 
            //    ctrl.ForeColor = getButtonTextColor(coord);
            //}
        }
        private void doubleClick(object sender, MouseEventArgs e)
        {

        }
        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            room.save(saveFileDialog.FileName);
        }
        private string getButtonText(Point coord)
        {
            string separator = " ";

            Button button = cells[coord.X, coord.Y];

            if (room.rewards.GetRewardOnCoord(coord) != null && room.rewards.GetRewardOnCoord(coord).Type != RewardType.None)
                separator = "*";

            return coord.X.ToString() + separator + coord.Y.ToString();
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'm')
                monster_radioButton.Checked = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
                monster_radioButton.Checked = true;
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
                monster_radioButton.Checked = true;
        }
    }
}