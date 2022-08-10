namespace RoomCreator
{
    public partial class Form1 : Form
    {
        private Room room;
        private Button[,] cells;
        public Form1()
        {
            InitializeComponent();
            room = new Room();

            cells = new Button[room.Width, room.Height];

            generateMap();
        }

        private void click(object sender, EventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
                settings_contextMenuStrip.Show(Cursor.Position);
        }


        private void generateMap()
        {
            Point start = new Point(3, 50);
            Size buttonSize = new Size(50, 50);

            for (int row = 0; row < room.Height; ++row)
            {
                for(int col = 0; col < room.Width; ++col)
                {
                    Button newButton = new Button();
                    this.Controls.Add(newButton);

                    newButton.Text =  row + " " + col;
                    newButton.Location = new Point(row * buttonSize.Width + start.X, col * buttonSize.Height + start.Y);
                    newButton.Size = new Size(50, 50);

                    newButton.MouseDown += new MouseEventHandler(click);
                    newButton.Click += new EventHandler(click);

                    cells[row, col] = newButton;
                }
            }
            Size = new Size(room.Width * buttonSize.Width + 23, room.Height * buttonSize.Height + 100);
        }

        private void sizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form settings = new SettingsForm(ref room);
            settings.ShowDialog();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            room.load(openFileDialog.FileName);
        }

        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            room.save(saveFileDialog.FileName);
        }
    }
}