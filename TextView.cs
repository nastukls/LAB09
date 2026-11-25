using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    public class TextView : Widget, IResizable
    {
        public int MaxLength { get; set; }
        public string Text { get; set; }

        public TextView(int width, int height, string caption,
                        int maxLength, string text)
            : base(width, height, caption)
        {
            MaxLength = maxLength;
            Text = text;
        }

        public void Resize(int newWidth, int newHeight)
        {
            Width = newWidth;
            Height = newHeight;

            Console.WriteLine($"TextView resized: {Width} x {Height}");
        }

        public void SetText(string text)
        {
            if (text.Length <= MaxLength)
            {
                Text = text;
            }
            else
            {
                Console.WriteLine("Text is too long");
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", MaxLength: {MaxLength}, Text: {Text}";
        }
    }
}
