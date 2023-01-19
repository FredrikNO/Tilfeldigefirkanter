using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilfeldigefirkanter
{
    internal class VirtualScreen
    {
        private VirtualScreenRow[] _rows;
        private int Width { get; set; }
        private int Height { get; set; }

        public VirtualScreen(int width, int height)
        {
            _rows= new VirtualScreenRow[height];
            Width = width;
            Height = height;
        }

        public void Add(Box box)
        {
            for (int i = 0; i < box.StartY; i++)
            {
                _rows[i] = new VirtualScreenRow(Width);
            }
            _rows[box.StartY] = new VirtualScreenRow(Width);
            _rows[box.StartY].AddBoxTopRow(box.X,box.Width);
            for (int i = box.StartY+1; i < box.Height; i++)
            {
                _rows[i] = new VirtualScreenRow(Width);
                _rows[i].AddBoxMiddleRow(box.X, box.Width);
            }
            _rows[box.Height] = new VirtualScreenRow(Width);
            _rows[box.Height].AddBoxTopRow(box.X, box.Width);
        }
        public void Show()
        {
            for (int i = 0; i < _rows.Length; i++)
            {
                _rows[i].Show();
            }
        }
    }
}
