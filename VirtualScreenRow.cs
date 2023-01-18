using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilfeldigefirkanter
{
    internal class VirtualScreenRow
    {

        private VirtualScreenCell[] _cells;

        public VirtualScreenRow(int screenWidth)
        {
            _cells = new VirtualScreenCell[screenWidth];
        }

        public void AddBoxTopRow(int boxX, int boxWidth)
        {
            string TopBox = String.Empty;
            for (int i = 0; i < boxX; i++)
            {
                _cells[i] = new VirtualScreenCell();
                TopBox += _cells[i].GetCharacter().ToString();
            }
            _cells[boxX] = new VirtualScreenCell();
            _cells[boxX].AddLowerLeftCorner();
            TopBox += _cells[boxX].GetCharacter().ToString();
            for (int i = boxX+1; i < boxX+boxWidth-1; i++)
            {
                _cells[i] = new VirtualScreenCell();
                _cells[i].AddHorizontal();
                TopBox += _cells[i].GetCharacter().ToString();
            }
            _cells[boxX+boxWidth] = new VirtualScreenCell();
            _cells[boxX + boxWidth].AddLowerRightCorner();
            TopBox += _cells[boxX + boxWidth].GetCharacter().ToString();
            Console.WriteLine(TopBox);
        }
        public void AddBoxBottomRow(int boxX, int boxWidth)
        {
            
        }
        public void AddBoxMiddleRow(int boxX, int boxWidth)
        {
            
        }
        public void Show()
        {
            
        }
    }
}
