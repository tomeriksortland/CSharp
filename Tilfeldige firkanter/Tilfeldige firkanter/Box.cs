﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tilfeldige_firkanter
{
    public class Box
    {
        public int X { get; }
        public int Y { get; }
        public int StartY
        {
            get { return Y; }
        }

        public int EndY => Y + Height;
        public int Width { get; }
        public int Height { get; }
        private const int _minimumSize = 3;

        public Box(Random random, int maxX, int maxY)
        {
            Width = random.Next(_minimumSize, maxX-1);
            Height = random.Next(_minimumSize, maxY-1);
            X = random.Next(1, maxX-1 - Width);
            Y = random.Next(1, maxY-1 - Height);
        }
    }
}
