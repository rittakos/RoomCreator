using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCreator
{
    public class SaveData
    {
        const string RoomExtension      = "rm";
        const string MonsterExtension   = "ms";
        const string RewardExtension    = "rw";

        private string folderPath = "";

        public bool     CreateFolder    = true;

        public string   FolderName      = "Room";
        public string   RoomFileName    = "room";
        public string   MonsterFileName = "monsters";
        public string   RewardFileName  = "rewards";

        public void     setPath(string path)
        {
            folderPath = Directory.GetParent(path).FullName;

            string[] parts = path.Split('\\');
            RoomFileName = parts[parts.Length - 1];
        }

        public string getRootPath()
        {
            return folderPath;
        }

        public void     createFolder()
        {
            if (CreateFolder)
            {
                folderPath += "\\";
                folderPath += FolderName;
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
            }
        }

        public string getRoomFilePath() 
        { 
            return folderPath + "\\" + RoomFileName + "." + RoomExtension; 
        }
        public string getMonsterFilePath() 
        { 
            return folderPath + "\\" + MonsterFileName + "." + MonsterExtension; 
        }
        public string getRewardFilePath() 
        { 
            return folderPath + "\\" + RewardFileName + "." + RewardExtension; 
        }
    }
}
