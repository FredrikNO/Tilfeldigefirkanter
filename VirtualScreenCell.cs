using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilfeldigefirkanter
{
    internal class VirtualScreenCell
    {
        public bool Up { get; private set; }
        public bool Down { get; private set; }
        public bool Left { get; private set; }
        public bool Right { get; private set; }

        //public VirtualScreenCell(bool up, bool down, bool left, bool right)
        //{
        //    Up = up;
        //    Down= down;
        //    Left = left;
        //    Right = right;
        //}
        public void AddHorizontal()
        {
            Left = true;
            Right = true;
        }
        public void AddVertical()
        {
            Up = true;
            Down = true;

        }

        public void AddLowerLeftCorner()
        {
            Right = true;
            Down = true;
        }
        public void AddUpperLeftCorner()
        {
            Up = true;
            Right = true;

        }
        public void AddUpperRightCorner()
        {
            Up = true;
            Left = true;
        }
        public void AddLowerRightCorner()
        {
            Down = true;
            Left = true;
        }
        public char GetCharacter()
        {
            char character = '\0';
            if (Up && Down && Left && Right) character = '┼';
            else if (Up && Down && Left) character = '┤';
            else if (Up && Down && Right) character = '├';
            else if (Up && Left && Right) character = '┴';
            else if (Down && Left && Right) character = '┬';
            else if (Up && Down) character = '│';
            else if (Up && Right) character = '└';
            else if (Up && Left) character = '┘';
            else if (Down && Right) character = '┌';
            else if (Down && Left) character = '┐';
            else if (Left && Right) character = '─';
            else if (Up) character = '╹';
            else if (Down) character = '╻';
            else if (Left) character = '╸';
            else if (Right) character = '╺';
            else character = ' ';
            return character;
        }
      
    }
}
