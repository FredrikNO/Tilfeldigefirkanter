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
        public string TopBox { get; private set; }
        public string MiddleBox { get; private set; }
        public string BottomBox { get; private set; }

        public VirtualScreenRow(int screenWidth)
        {
            _cells = new VirtualScreenCell[screenWidth];
            TopBox = string.Empty;
            MiddleBox = string.Empty;
            BottomBox = string.Empty;
        }

        public void AddBoxTopRow(int boxX, int boxWidth)
        {
            TopBox += AddPadding(boxX);
            TopBox += SetLowerLeftCorner(boxX);
            TopBox += AddHorizontalLine(boxX, boxWidth, true);
            TopBox += SetLowerRightCorner(boxX, boxWidth);
        }
        public void AddBoxBottomRow(int boxX, int boxWidth)
        {
            TopBox += AddPadding(boxX);
            TopBox += SetUpperLeftCorner(boxX);
            TopBox += AddHorizontalLine(boxX, boxWidth, true);
            TopBox += SetUpperRightCorner(boxX, boxWidth);
        }
        public void AddBoxMiddleRow(int boxX, int boxWidth)
        {
            MiddleBox += AddPadding(boxX);
            MiddleBox += SetVerticalLine(boxX, boxWidth, true);
            MiddleBox += AddHorizontalLine(boxX, boxWidth, false);
            MiddleBox += SetVerticalLine(boxX, boxWidth, false);
        }
        public void Show()
        {
            if(!String.IsNullOrWhiteSpace(TopBox))
            {
                Console.WriteLine(TopBox);
            }
            else if (!String.IsNullOrWhiteSpace(MiddleBox))
            {
                Console.WriteLine(MiddleBox);
            }
            else
            {
                Console.WriteLine(BottomBox);
            }
        }

        private string AddPadding(int boxX)
        {
            string box = String.Empty;
            for (int i = 0; i < boxX; i++)
            {
                _cells[i] = new VirtualScreenCell();
                box += _cells[i].GetCharacter().ToString();
            }
            return box;
        }
        private string SetLowerLeftCorner(int boxX)
        {
            string box = String.Empty;
            _cells[boxX] = new VirtualScreenCell();
            _cells[boxX].AddLowerLeftCorner();
            box += _cells[boxX].GetCharacter().ToString();
            return box;
        }
        private string AddHorizontalLine(int boxX, int boxWidth, bool line)
        {
            string box = String.Empty;
            for (int i = boxX + 1; i < boxX + boxWidth - 1; i++)
            {
                if (line)
                {
                    _cells[i] = new VirtualScreenCell();
                    _cells[i].AddHorizontal();
                    box += _cells[i].GetCharacter().ToString();
                }
                else
                {
                    _cells[i] = new VirtualScreenCell();
                    box += _cells[i].GetCharacter().ToString();
                }
                
            }
            return box;
        }
        private string SetLowerRightCorner(int boxX, int boxWidth)
        {
            string box = String.Empty;
            _cells[boxX + boxWidth] = new VirtualScreenCell();
            _cells[boxX + boxWidth].AddLowerRightCorner();
            box += _cells[boxX + boxWidth].GetCharacter().ToString();
            return box;
        }
        private string SetUpperLeftCorner(int boxX)
        {
            string box = String.Empty;
            _cells[boxX] = new VirtualScreenCell();
            _cells[boxX].AddUpperLeftCorner();
            box += _cells[boxX].GetCharacter().ToString();
            return box;
        }
        private string SetUpperRightCorner(int boxX, int boxWidth)
        {
            string box = String.Empty;
            _cells[boxX + boxWidth] = new VirtualScreenCell();
            _cells[boxX + boxWidth].AddUpperRightCorner();
            box += _cells[boxX + boxWidth].GetCharacter().ToString();
            return box;
        }
        private string SetVerticalLine(int boxX, int boxWidth, bool start)
        {
            string box = String.Empty;
            if (start)
            {
                _cells[boxX] = new VirtualScreenCell();
                _cells[boxX].AddVertical();
                box += _cells[boxX].GetCharacter().ToString();
                return box;
            }
            else
            {
                _cells[boxWidth] = new VirtualScreenCell();
                _cells[boxWidth].AddVertical();
                box += _cells[boxWidth].GetCharacter().ToString();
                return box;
            }
        }
    }
}
