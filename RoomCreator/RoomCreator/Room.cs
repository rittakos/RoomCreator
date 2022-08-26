using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCreator
{
    public enum CellType { Simple, Hole, GoodWater, BadWater }
    public enum MonsterType { None, Random, Spider, Mosquito, Worm, Caterpillar, Wasp, Type1, Type2 }
    public enum RoomRewardType { None, Gold, Item, Life, Random }
    public enum RewardType { None, Random, Gold, Item, Life, Type1, Type2 }
    public enum Direction { Left, Right, Up, Down }
    public class Walls
    {
        Dictionary<Direction, int> walls;

        public Walls()
        {
            walls = new Dictionary<Direction, int>();

            walls.Add(Direction.Left, 0);
            walls.Add(Direction.Right, 0);
            walls.Add(Direction.Up, 0);
            walls.Add(Direction.Down, 0);
        }

        public bool hasWall(Direction dir)
        {
            return walls[dir] != 0;
        }
        public void setWall(Direction dir, int count = 1)
        {
            if (walls.ContainsKey(dir))
                walls[dir] = count;
            else
                walls.Add(dir, count);
        }

        public void setWall(Direction dir, bool hasWall)
        {
            int count = hasWall ? 1 : 0;
            if (walls.ContainsKey(dir))
                walls[dir] = count;
            else
                walls.Add(dir, count);
        }

        public string GetStringToSerialize()
        {
            string result = "";

            result += (walls[Direction.Left].ToString() + " ");
            result += (walls[Direction.Right].ToString() + " ");
            result += (walls[Direction.Up].ToString() + " ");
            result += (walls[Direction.Down].ToString());

            return result;
        }

        public void SetWallsFromFile(string input)
        {
            string[] wallStrings = input.Split(' ');

            walls.Clear();

            walls.Add(Direction.Left, Convert.ToInt32(wallStrings[0]));
            walls.Add(Direction.Right, Convert.ToInt32(wallStrings[1]));
            walls.Add(Direction.Up, Convert.ToInt32(wallStrings[2]));
            walls.Add(Direction.Down, Convert.ToInt32(wallStrings[3]));
        }
    }
    public class Cell
    {
        public CellType Type;
        //public Monster  Monster;
        //public Reward   Reward;

        public Cell()
        {
            Type = CellType.Simple;
            //Monster = new Monster();
            //Reward = new Reward();
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

    public class Monster
    {
        public MonsterType Type;
        public Point Coord;

        public string ToSerializableString()
        {
            string line = "";
            line += Coord.X;
            line += " ";
            line += Coord.Y;
            line += " ";

            if (Type != MonsterType.None)
                line += Type.ToString();

            return line;
        }

        public static string getStringToDisplay(MonsterType type)
        {
            string res = "M";

            if (type == MonsterType.None)
                return "";

            if (type == MonsterType.Random)
                return "Rnd";

            switch (type)
            {
                case MonsterType.Spider:
                    return "Spd";
                case MonsterType.Wasp:
                    return type.ToString();
                case MonsterType.Worm:
                    return type.ToString();
                case MonsterType.Caterpillar:
                    return "Ctr";
                case MonsterType.Mosquito:
                    return "Msq";
                default:
                    return res + type.ToString().Last();
            }

            return res + type.ToString().Last();

            //switch (type)
            //{
            //    case RewardType.Item:
            //        return type.ToString();
            //    case RewardType.Gold:
            //        return type.ToString();
            //    case RewardType.Life:
            //        return type.ToString();
            //    case RewardType.Random:
            //        return type.ToString();
            //    default:
            //        return res + type.ToString().Last();
            //}

            //return "";
        }

        public Monster(string type, Point coord)
        {
            Enum.TryParse<MonsterType>(type, out MonsterType t);
            Type = t;

            Coord = coord;
        }

        public Monster(MonsterType type, Point coord)
        {
            Type = type;
            Coord = coord;
        }
    }

    public class Reward
    {
        public RewardType Type;
        public Point Coord;
        public string ToSerializableString()
        {
            string line = "";

            line += Coord.X;
            line += " ";
            line += Coord.Y;
            line += " ";

            if (Type != RewardType.None)
                line += Type.ToString();

            return line;
        }
        public Reward(string type, Point coord)
        {
            Enum.TryParse<RewardType>(type, out RewardType t);
            Type = t;

            Coord = coord;
        }
        public Reward(RewardType type, Point coord)
        {
            Type = type;
            Coord = coord;
        }

        public static string getStringToDisplay(RewardType type)
        {
            string res = "R";

            if (type == RewardType.None)
                return "";

            if (type == RewardType.Random)
                return "Rnd";

            switch(type)
            {
                case RewardType.Item:
                    return type.ToString();
                case RewardType.Gold:
                    return type.ToString();
                case RewardType.Life:
                    return type.ToString();
                case RewardType.Random:
                    return type.ToString();
                default:
                    return res + type.ToString().Last();
            }

            return "";
        }
    }

    public class Monsters
    {
        //private List<Monster> monsters;
        public Dictionary<Point, Monster> monsters;
        public Monsters()
        {
            monsters = new Dictionary<Point, Monster>();
        }
        public Monster GetMonsterOnCoord(Point coord)
        {
            if(monsters.ContainsKey(coord))
                return monsters[coord];
            return null;
        }
        public void RemoveMonster(Point coord)
        {
            monsters.Remove(coord);
        }
        public MonsterType changeMonster(Point coord, MonsterType type)
        {
            if(monsters.ContainsKey(coord))
            {
                monsters[coord].Type = type;
            }else
            {
                monsters.Add(coord, new Monster(type, coord));
            }

            return monsters[coord].Type;

            //if (cells[row, col].Monster == MonsterType.Random)
            //    cells[row, col].Monster = MonsterType.None;
            //else if (cells[row, col].Monster == MonsterType.None)
            //    cells[row, col].Monster = MonsterType.Random;

            //return cells[row, col].Monster;
        }

        internal MonsterType AddMonster(Point coord, string type)
        {
            if (!monsters.ContainsKey(coord))
            {
                monsters.Add(coord, new Monster(type, coord));
            }

            return monsters[coord].Type;
        }
    }

    public class Rewards
    {
        //private List<Reward> rewards;
        public Dictionary<Point, Reward> rewards;
        public Rewards()
        {
            rewards = new Dictionary<Point, Reward>();
        }
        public Reward GetRewardOnCoord(Point coord)
        {
            if (rewards.ContainsKey(coord))
                return rewards[coord];
            return null;
        }
        public void RemoveReward(Point coord)
        {
            rewards.Remove(coord);
        }
        public RewardType changeReward(Point coord, RewardType type)
        {
            if (rewards.ContainsKey(coord))
            {
                rewards[coord].Type = type;
            }
            else
            {
                rewards.Add(coord, new Reward(type, coord));
            }

            return rewards[coord].Type;

            //if (cells[row, col].Reward == RewardType.None)
            //    cells[row, col].Reward = RewardType.Random;
            //else if (cells[row, col].Reward == RewardType.Random)
            //    cells[row, col].Reward = RewardType.None;

            //return cells[row, col].Reward;
        }

        public RewardType AddReward(Point coord, string type)
        {
            if (!rewards.ContainsKey(coord))
            {
                rewards.Add(coord, new Reward(type, coord));
            }

            return rewards[coord].Type;
        }
    }

    public class Room : ICloneable
    {
        //Private data
        private const int       version1 = 1;
        private const int       headerDataCount = 10;

        private int             currentVersion = version1;

        private Cell[,]         cells;
        public Monsters         monsters;
        public Rewards          rewards;



        //Public data
        public int              Width;
        public int              Height;

        public string           Name;
        public int              ID;
        public string           Description;

        public bool             IsWall;

        public Walls            Wall;
        public RoomRewardType   RoomReward;
        public int              Level;

        public SaveData         SaveData;

        public bool             NeedReset = false;

        //Constructors
        public Room()
        {
            Width       = 10;
            Height      = 10;

            Name        = "Room";
            ID          = 0;
            Description = "";

            Wall      = new Walls();
            RoomReward  = RoomRewardType.None;
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
            rewards.rewards.Clear();

            for (int r = 0; r < lines.Length; ++r)
            {
                string[] reward = lines[r].Split(' ');
                int x = Convert.ToInt32(reward[0]);
                int y = Convert.ToInt32(reward[1]);

                rewards.AddReward(new Point(x, y), reward[2]);

                //if (reward[2] == "Random")
                //    cells[x, y].Reward = RewardType.Random;
            }

            return true;
        }
        private bool loadMonsters(string path)
        {
            string[] lines = File.ReadAllLines(path);

            for(int m = 0; m < lines.Length; ++m)
            {
                string[] data = lines[m].Split(' ');
                int x = Convert.ToInt32(data[0]);
                int y = Convert.ToInt32(data[1]);
                monsters.AddMonster(new Point(x, y), data[2]);
                //string[] data = lines[m].Split(' ');
                //int x = Convert.ToInt32(data[0]);
                //int y = Convert.ToInt32(data[1]);

                //cells[x, y].Monster = Monster.CreateMonster(lines[m]);
            }

            return true;
        }
        public void load(string path)
        {
            string monsterPath = "";
            string rewardPath = "";

            string[] lines = File.ReadAllLines(path);

            currentVersion  = Convert.ToInt32(lines[0]);
            Name            = lines[1].Split(' ')[0];
            ID              = Convert.ToInt32(lines[1].Split(' ')[1]);
            Description     = lines[2];
            IsWall          = Convert.ToInt32(lines[3]) == 0 ? false : true;
            Width           = Convert.ToInt32(lines[4].Split(' ')[0]);
            Height          = Convert.ToInt32(lines[4].Split(' ')[1]);
            Enum.TryParse<RoomRewardType>(lines[5], out RoomRewardType roomReward);
            RoomReward      = roomReward;
            Level           = Convert.ToInt32(lines[6]);
            Wall.SetWallsFromFile(lines[7]);
            monsterPath     = lines[8];
            rewardPath      = lines[9];


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
                writer.WriteLine(currentVersion);
                writer.WriteLine("{0} {1}", Name, ID);
                writer.WriteLine(Description);
                writer.WriteLine(IsWall ? "1" : "0");
                writer.WriteLine("{0} {1}", Width, Height);
                writer.WriteLine(RoomReward.ToString());
                writer.WriteLine(Level);
                writer.WriteLine(Wall.GetStringToSerialize());
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
                foreach (KeyValuePair<Point, Monster> monster in monsters.monsters)
                    writer.WriteLine(monster.Value.ToSerializableString());
                //for (int row = 0; row < Height; ++row)
                //{
                //    for (int col = 0; col < Width; ++col)
                //    {
                //        if (cells[row, col].Monster == MonsterType.Random)
                //        {
                //            string line = "";
                //            line += row;
                //            line += " ";
                //            line += col;
                //            line += " ";
                //            line += "Random";

                //            writer.WriteLine(line);
                //        }
                //    }
                //}
            }

            return true;
        }
        private bool saveRewards(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach(KeyValuePair<Point, Reward> reward in rewards.rewards)
                    writer.WriteLine(reward.Value.ToSerializableString());
                //for (int row = 0; row < Height; ++row)
                //{
                //    for (int col = 0; col < Width; ++col)
                //    {
                //        string line = "";
                //        if (cells[row, col].Reward != RewardType.None)
                //        {
                //            line += row;
                //            line += " ";
                //            line += col;
                //            line += " ";
                //        } else
                //            continue;

                //        if(cells[row, col].Reward == RewardType.Random)
                //           line += "Random";


                //        writer.WriteLine(line);
                //    }
                //}
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
            cells = new Cell[Height, Width];
            monsters = new Monsters();
            rewards = new Rewards();
            NeedReset = false;

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



        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
