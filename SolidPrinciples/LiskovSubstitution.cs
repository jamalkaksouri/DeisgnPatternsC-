﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle()
        {

        }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}:{Height}";
        }
    }
    public class Square : Rectangle
    {
        public new int Width
        {
            set { base.Width = base.Height = value; }
        }
        public new int Height
        {
            set { base.Width = base.Height = value; }
        }
    }
    public class LiskovSubstitution
    {

    }
}
