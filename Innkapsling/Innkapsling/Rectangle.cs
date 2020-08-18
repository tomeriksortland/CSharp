using System;
using System.Collections.Generic;
using System.Text;

namespace Innkapsling
{
    class Rectangle
    {
        public int Area => Width * Height;
        public int Width { get; set; }

        public int Height { get; set; }
        //{
        //    get => Area / Width;
        //    set => Area = Width * value;
        //}

        public Rectangle(int width, int height)
        {
            Height = width * height;
            Width = width;
        }

       
    }
}
