using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCreator
{
    public enum CellType { Simple, Water, Hole}
 
    public class Cell
    {
        public CellType Type;
        public bool Monster;

        public Cell()
        {
            Type = CellType.Simple;
            Monster = false;
        }

        public Color getColor()
        {
            switch (Type)
            {
                case CellType.Simple:
                    return Color.White;
                case CellType.Water:
                    return Color.Blue;
                case CellType.Hole:
                    return Color.Black;
                default: 
                    return Color.Black;
            }
        }
    }
    
    public class Room : ICloneable
    {
        public int Width;
        public int Height;

        private Cell[,] cells;

        public Room()
        {
            Width = 10;
            Height = 10;

            resetRoom();

            cells[0, 0].Type = CellType.Water;
            cells[0, 5].Monster = true;
            //save(@"C:\Users\akosr\OneDrive\Desktop\Room");
        }

        public Room(string path)
        {
            this.load(path);
        }

        private bool loadMonsters(string path)
        {
            string[] lines = File.ReadAllLines(path);

            for(int m = 0; m < lines.Length; ++m)
            {
                string[] monster = lines[m].Split(' ');
                int x = Convert.ToInt32(monster[0]);
                int y = Convert.ToInt32(monster[1]);
                cells[x, y].Monster = true;
            }

            return true;
        }

        public void load(string path)
        {
            string monsterPath = "";

            string[] lines = File.ReadAllLines(path + @"\room.rm");

            Width = Convert.ToInt32(lines[0].Split(' ')[0]);
            Height = Convert.ToInt32(lines[0].Split(' ')[1]);
            monsterPath = lines[1];

            resetRoom();

            for(int row = 0; row < Height; row++)
            {
                string line = lines[2 + row];
                for (int col = 0; col < Width; col++)
                {
                    if(line[col] == 'S')
                        cells[row, col].Type = CellType.Simple;
                    else if (line[col] == 'W')
                        cells[row, col].Type = CellType.Water;
                    else if (line[col] == 'H')
                        cells[row, col].Type = CellType.Hole;
                }
            }

            loadMonsters(monsterPath);
        }

        private bool saveRoom(string path, string monsterPath)
        {

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("{0} {1}", Width, Height);
                writer.WriteLine(monsterPath);
                for (int row = 0; row < Height; ++row)
                {
                    string line = "";
                    for (int col = 0; col < Width; ++col)
                    {
                        switch (cells[row, col].Type)
                        {
                            case CellType.Simple:
                                line += "S";
                                break;
                            case CellType.Water:
                                line += "W";
                                break;
                            case CellType.Hole:
                                line += "H";
                                break;
                        }

                        if (cells[row, col].Monster)
                        {

                        }
                    }
                    writer.WriteLine(line);
                }
            }


            return true;
        }

        private bool saveMonsters(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int row = 0; row < Height; ++row)
                {
                    for (int col = 0; col < Width; ++col)
                    {
                        if (cells[row, col].Monster)
                        {
                            string line = "";
                            line += row;
                            line += " ";
                            line += col;
                            line += " ";
                            line += "Monster";

                            writer.WriteLine(line);
                        }
                    }
                }
            }

            return true;
        }

        public void save(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            DirectoryInfo folder = new DirectoryInfo(path);
            if (folder.GetFileSystemInfos().Length == 0)
            {
                string monsterPath = path + @"\monsters.ms";
                string roomPath = path + @"\room.rm";

                saveMonsters(monsterPath);
                saveRoom(roomPath, monsterPath);
            }
        }

        public void resetRoom()
        {
            cells = new Cell[Width, Height];

            for (int row = 0; row < Height; ++row)
            {
                for (int col = 0; col < Width; ++col)
                {
                    cells[row, col] = new Cell();
                }
            }
        }

        public Cell getCell(Point coord)
        {
            return cells[coord.X, coord.Y];
        }

        public CellType changeCellType(Point coord)
        {
            int row = coord.X;
            int col = coord.Y;

            CellType type = CellType.Simple;

            switch(cells[row, col].Type)
            {
                case CellType.Simple: type = CellType.Water;
                    break;
                case CellType.Water: type = CellType.Hole;
                    break;
                case CellType.Hole: type = CellType.Simple;
                    break;
            }

            cells[row, col].Type = type;
            return type;
        }

        internal bool changeMonster(Point coord)
        {
            int row = coord.X;
            int col = coord.Y;

            cells[row, col].Monster = !cells[row, col].Monster;
            return cells[row, col].Monster;
        }

        internal bool changeReward(Point coord)
        {
            int row = coord.X;
            int col = coord.Y;

            cells[row, col].Monster = !cells[row, col].Monster;
            return cells[row, col].Monster;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
