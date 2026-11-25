using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace LAB09
{
    public class Grid : Widget, IResizable
    {
        public int Rows { get; set; }
        public int Columns { get; set; }

        private Widget?[,] elements;

        public Grid(int width, int height, string caption,
                    int rows, int columns)
            : base(width, height, caption)
        {
            Rows = rows;
            Columns = columns;

            elements = new Widget?[Rows, Columns];
        }

        public void AddToGrid(Widget w, int row, int column)
        {
            if (row < 0 || row >= Rows ||
                column < 0 || column >= Columns)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            if (elements[row, column] != null)
            {
                Console.WriteLine("This position is already occupied");
                return;
            }

            elements[row, column] = w;

            Console.WriteLine("Element added");
        }

        public void DeleteFromGrid(Widget w)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (elements[i, j] == w)
                    {
                        elements[i, j] = null;
                        Console.WriteLine("Element deleted");
                        return;
                    }
                }
            }

            Console.WriteLine("Element not found");
        }

        public void ShowAllElements()
        {
            Console.WriteLine($"Grid: {Caption}");
            Console.WriteLine($"Rows: {Rows}, Columns: {Columns}");

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (elements[i, j] != null)
                    {
                        Console.WriteLine($"Position [{i}, {j}]: {elements[i, j]}");
                    }
                }
            }
        }

        public bool NeedResize(int newRows, int newColumns)
        {
            return newRows != Rows || newColumns != Columns;
        }

        public void Resize(int newWidth, int newHeight)
        {
            Width = newWidth;
            Height = newHeight;

            Console.WriteLine($"Grid resized: {Width} x {Height}");
        }
    }
}