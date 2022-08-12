using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCreator
{
    public enum CellType    { Simple, Hole, GoodWater, BadWater }
    public enum MonsterType { None, Random }
    public enum RewardType  { None, Gold, Item, Life, Random }

    public class Cell
    {
        public CellType     Type;
        public MonsterType  Monster;
        public RewardType   Reward;

        public Cell()
        {
            Type = CellType.Simple;
            Monster = MonsterType.None;
            Reward = RewardType.None;
        }

        public Color getColor()
        {
            switch (Type)
            {
                case CellType.Simple:
                    return Color.White;
                case CellType.BadWater:
                    return Color.Blue;
                case CellType.GoodWater:
                    return Color.LightBlue;
                case CellType.Hole:
                    return Color.Black;
                default: 
                    return Color.Black;
            }
        }

        public Color getTextColor()
        {
            switch (Type)
            {
                case CellType.Simple:
                    return Color.Black;
                case CellType.BadWater:
                    return Color.White;
                case CellType.GoodWater:
                    return Color.Black;
                case CellType.Hole:
                    return Color.White;
                default:
                    return Color.Black;
            }
        }
    }
    
    public class Room : ICloneable
    {
        //Private data
        private const int   headerDataCount = 7;
        private Cell[,]     cells;


        //Public data
        public int          Width;
        public int          Height;

        public string       Name;
        public int          ID;
        public string       Description;

        public RewardType   RoomReward;
        public int Level;

        public SaveData     SaveData;

        //Constructors
        public Room()
        {
            Width       = 10;
            Height      = 10;

            Name        = "Room";
            ID          = 0;
            Description = "";

            RoomReward  = RewardType.None;
            Level = 10;

            SaveData    = new SaveData();


            resetRoom();

            //cells[0, 0].Type = CellType.Water;
            //cells[0, 5].Monster = MonsterType.Random;
        }

        public Room(string path)
        {
            this.load(path);
        }


        private bool loadRewards(string path)
        {
            string[] lines = File.ReadAllLines(path);

            for (int r = 0; r < lines.Length; ++r)
            {
                string[] reward = lines[r].Split(' ');
                int x = Convert.ToInt32(reward[0]);
                int y = Convert.ToInt32(reward[1]);

                if (reward[2] == "Random")
                    cells[x, y].Reward = RewardType.Random;
            }

            return true;
        }
        private bool loadMonsters(string path)
        {
            string[] lines = File.ReadAllLines(path);

            for(int m = 0; m < lines.Length; ++m)
            {
                string[] monster = lines[m].Split(' ');
                int x = Convert.ToInt32(monster[0]);
                int y = Convert.ToInt32(monster[1]);

                if (monster[2] == "Random")
                    cells[x, y].Monster = MonsterType.Random;
            }

            return true;
        }
        public void load(string path)
        {
            string monsterPath = "";
            string rewardPath = "";

            string[] lines = File.ReadAllLines(path);

            Name        = lines[0].Split(' ')[0];
            ID          = Convert.ToInt32(lines[0].Split(' ')[1]);
            Description = lines[1];
            Width       = Convert.ToInt32(lines[2].Split(' ')[0]);
            Height      = Convert.ToInt32(lines[2].Split(' ')[1]);
            Enum.TryParse<RewardType>(lines[3], out RewardType roomReward);
            RoomReward  = roomReward;
            Level       = Convert.ToInt32(lines[4]);
            monsterPath = lines[5];
            rewardPath  = lines[6];


            resetRoom();

            for(int row = 0; row < Height; row++)
            {
                string line = lines[headerDataCount + row];
                for (int col = 0; col < Width; col++)
                {
                    if(line[col] == 'S')
                        cells[row, col].Type = CellType.Simple;
                    else if (line[col] == 'G')
                        cells[row, col].Type = CellType.GoodWater;
                    else if (line[col] == 'B')
                        cells[row, col].Type = CellType.BadWater;
                    else if (line[col] == 'H')
                        cells[row, col].Type = CellType.Hole;
                }
            }

            loadMonsters(monsterPath);
            loadRewards(rewardPath);
        }


        private bool saveRoom(string path, string monsterPath, string rewardPath)
        {

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("{0} {1}", Name, ID);
                writer.WriteLine(Description);
                writer.WriteLine("{0} {1}", Width, Height);
                writer.WriteLine(RoomReward.ToString());
                writer.WriteLine(Level);
                writer.WriteLine(monsterPath);
                writer.WriteLine(rewardPath);

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
                            case CellType.GoodWater:
                                line += "G";
                                break;
                            case CellType.BadWater:
                                line += "B";
                                break;
                            case CellType.Hole:
                                line += "H";
                                break;
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
                        if (cells[row, col].Monster == MonsterType.Random)
                        {
                            string line = "";
                            line += row;
                            line += " ";
                            line += col;
                            line += " ";
                            line += "Random";

                            writer.WriteLine(line);
                        }
                    }
                }
            }

            return true;
        }
        private bool saveRewards(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int row = 0; row < Height; ++row)
                {
                    for (int col = 0; col < Width; ++col)
                    {
                        string line = "";
                        if (cells[row, col].Reward != RewardType.None)
                        {
                            line += row;
                            line += " ";
                            line += col;
                            line += " ";
                        } else
                            continue;

                        if(cells[row, col].Reward == RewardType.Random)
                           line += "Random";


                        writer.WriteLine(line);
                    }
                }
            }

            return true;
        }
        public void save(string path)
        {
            SaveData.setPath(path);
            SaveData.createFolder();

            string monsterPath = SaveData.getMonsterFilePath();
            string rewardPath = SaveData.getRewardFilePath();
            string roomPath = SaveData.getRoomFilePath();

            saveMonsters(monsterPath);
            saveRewards(rewardPath);
            saveRoom(roomPath, monsterPath, rewardPath);

            //DirectoryInfo folder = new DirectoryInfo(SaveData.getRootPath());
            //if (folder.GetFileSystemInfos().Length == 0)
            //{
                
            //}
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
                case CellType.Simple: type = CellType.Hole;
                    break;
                case CellType.Hole: type = CellType.GoodWater;
                    break;
                case CellType.GoodWater: type = CellType.BadWater;
                    break;
                case CellType.BadWater: type = CellType.Simple;
                    break;
            }

            cells[row, col].Type = type;
            return type;
        }
        internal MonsterType changeMonster(Point coord)
        {
            int row = coord.X;
            int col = coord.Y;

            if(cells[row, col].Monster == MonsterType.Random)
                cells[row, col].Monster = MonsterType.None;
            else if (cells[row, col].Monster == MonsterType.None)
                cells[row, col].Monster = MonsterType.Random;

            return cells[row, col].Monster;
        }
        internal RewardType changeReward(Point coord)
        {
            int row = coord.X;
            int col = coord.Y;

            if (cells[row, col].Reward == RewardType.None)
                cells[row, col].Reward = RewardType.Random;
            else if (cells[row, col].Reward == RewardType.Random)
                cells[row, col].Reward = RewardType.None;

            return cells[row, col].Reward;
        }



        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
