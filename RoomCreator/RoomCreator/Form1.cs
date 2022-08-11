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


        private string getButtonText(Point coord)
        {
            string separator = " ";

            Button button = cells[coord.X, coord.Y];

            if (room.getCell(coord).Reward != RewardType.None)
                separator = "*";
            
            return coord.X.ToString() + separator + coord.Y.ToString();
        }
        private Color getButtonTextColor(Point coord)
        {
            Color color = Color.White;
            
            Button button = cells[coord.X, coord.Y];

            if (room.getCell(coord).Monster == MonsterType.Random)
                return Color.Red;

            if (button.BackColor == Color.White)
                color = Color.Black;
            else if (button.BackColor == Color.Blue)
                color = Color.White;
            else if (button.BackColor == Color.Black)
                color = Color.White;
            else
                color = Color.Black;

            return color;
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
        private void reset()
        {
            foreach(Button b in cells)
            {
                this.Controls.Remove(b);
            }
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

                    newButton.Text =  getButtonText(coord);
                    newButton.Font = buttonTextFont;
                    newButton.Location = new Point(row * buttonSize.Width + start.X, col * buttonSize.Height + start.Y);
                    newButton.Size = new Size(50, 50);
                    newButton.BackColor = currnetCell.getColor();

                    newButton.Click += new EventHandler(leftClick);

                    newButton.MouseDown += new MouseEventHandler(rightClick);
                    newButton.MouseDoubleClick += new MouseEventHandler(doubleClick);
                    //newButton.Click += new EventHandler(leftClick);

                    cells[row, col] = newButton;
                    newButton.ForeColor = getButtonTextColor(coord);
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
                room.changeMonster(coord);
            else if (reward_radioButton.Checked)
                room.changeReward(coord);

            button.BackColor    = room.getCell(coord).getColor();
            button.ForeColor    = getButtonTextColor(coord);
            button.Text         = getButtonText(coord);
        }
        private void sizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form settings = new SettingsForm(ref room);
            DialogResult result = settings.ShowDialog();

            if (result == DialogResult.OK)
            {
                reset();
                generateMap();
            }
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DialogResult result = openFileDialog.ShowDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                room.load(folderBrowserDialog1.SelectedPath);
                reset();
                generateMap();
            }

        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saveFileDialog.ShowDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
                room.save(folderBrowserDialog1.SelectedPath);
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
        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            room.load(openFileDialog.FileName);
        }
        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            room.save(saveFileDialog.FileName);
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