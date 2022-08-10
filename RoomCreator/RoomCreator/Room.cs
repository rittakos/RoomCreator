using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCreator
{
    public class Room : ICloneable
    {
        public int Width;
        public int Height;

        public Room()
        {
            Width = 10;
            Height = 10;
        }

        public Room(string path)
        {
            this.load(path);
        }

        public void load(string path)
        {

        }

        public void save(string path)
        {

        }

        public void resetRoom()
        {

        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
