using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Tilfeldige_firkanter
{
    class VirtualScreenCell
    {
        public bool Up { get; private set; }
        public bool Down { get; private set; }
        public bool Left { get; private set; }
        public bool Right { get; private set; }


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
            Up = true;
            Right = true;
        }

        public void AddUpperLeftCorner()
        {
            Down = true;
            Right = true;
        }

        public void AddUpperRightCorner()
        {
            Down = true;
            Left = true;
        }

        public void AddLowerRightCorner()
        {
            Up = true;
            Left = true;
        }



        public char GetCharacter()
        {
            if (!Up && !Down && !Left && !Right) return ' ';
            if (!Up && !Down && !Left && Right) return '╺';
            if (!Up && !Down && Left && !Right) return '╸';
            if (!Up && !Down && Left && Right) return '─';
            if (!Up && Down && !Left && !Right) return '╻';
            if (!Up && Down && !Left && Right) return '┌';
            if (!Up && Down && Left && !Right) return '┐';
            if (!Up && Down && Left && Right) return '┬';
            
            
            if (Up && !Down && !Left && !Right) return '╹';
            if (Up && !Down && Left && !Right) return '┘';
            if (Up && !Down && !Left && Right) return '└';
            if (Up && !Down && Left && Right) return '┴';
            if (Up && Down && !Left && !Right) return '│';
            if (Up && Down && !Left && Right) return '├';
            if (Up && Down && Left && !Right) return '┤';
            if (Up && Down && Left && Right) return '┼';

            return 'x';
        }
    }
}


