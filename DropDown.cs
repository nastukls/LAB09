using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    public class DropDown : Widget, IClickable
    {
        public List<string> Items { get; set; }
        public string SelectedItem { get; set; }

        public DropDown(int width, int height, string caption)
            : base(width, height, caption)
        {
            Items = new List<string>();
            SelectedItem = "";
        }

        public void Click()
        {
            Console.WriteLine("DropDown opened");

            foreach (string item in Items)
            {
                Console.WriteLine(item);
            }
        }

        public void AddItem(string item)
        {
            Items.Add(item);
        }

        public void SelectItem(string item)
        {
            if (Items.Contains(item))
            {
                SelectedItem = item;
                Console.WriteLine($"Selected: {SelectedItem}");
            }
            else
            {
                Console.WriteLine("Item not found");
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", SelectedItem: {SelectedItem}";
        }
    }
}
