using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    public class Widget
    {
        private int width;
        private int height;

        public string Caption { get; set; }

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public Widget(int width, int height, string caption)
        {
            this.width = width;
            this.height = height;
            Caption = caption;
        }

        public override string ToString()
        {
            return $"Caption: {Caption}, Width: {Width}, Height: {Height}";
        }
    }
}