using System;
using System.Collections.Generic;
using System.Text;

namespace Tilfeldige_firkanter
{
    public class VirtualScreenRow
    {
        private readonly VirtualScreenCell[] _cells;

        public VirtualScreenRow(int screenWidth)
        {
            _cells = new VirtualScreenCell[screenWidth];
            for (var i = 0; i < _cells.Length; i++)
            {
                _cells[i] = new VirtualScreenCell();
            }
        }

        public void AddBoxTopRow(int boxX, int boxWidth)
        {
            _cells[boxX].AddUpperLeftCorner();
            var boxEndX = boxX + boxWidth - 1;
            for (int i = boxX + 1; i < boxEndX; i++)
            {
                _cells[i].AddHorizontal();
            }
            _cells[boxEndX].AddUpperRightCorner();
        }

        public void AddBoxMiddleRow(int boxX, int boxWidth)
        {
            _cells[boxX].AddVertical();
            var boxEndX = boxX + boxWidth - 1;

            _cells[boxEndX].AddVertical();
        }
        
        public void AddBoxBottomRow(int boxX, int boxWidth)
        {

            _cells[boxX].AddLowerLeftCorner();
            var boxEndX = boxX + boxWidth - 1;
            for (int i = boxX + 1; i < boxEndX; i++)
            {
                _cells[i].AddHorizontal();
            }
            _cells[boxEndX].AddLowerRightCorner();
        }


        public void Show()
        {
            foreach (var cell in _cells)
            {
                Console.Write(cell.GetCharacter());
            }
            Console.WriteLine();
        }
    }
}
