using LAB09;

Grid grid = new Grid(800, 600, "My Application", 2, 2);

Button button = new Button(
    100, 40, "Button", "Click", true
);

TextView textView = new TextView(
    200, 50, "Text field", 20, "Hello"
);

DropDown dropDown = new DropDown(
    150, 40, "Drop-down list"
);

Button button2 = new Button(
    120, 50, "Second button", "Send", false
);

dropDown.AddItem("Option 1");
dropDown.AddItem("Option 2");
dropDown.AddItem("Option 3");

grid.AddToGrid(button, 0, 0);
grid.AddToGrid(textView, 0, 1);
grid.AddToGrid(dropDown, 1, 0);
grid.AddToGrid(button2, 1, 1);

Console.WriteLine("\nAll elements:");
grid.ShowAllElements();

Console.WriteLine("\nAdding element to occupied position:");
grid.AddToGrid(button, 0, 0);

Console.WriteLine("\nDeleting element:");
grid.DeleteFromGrid(textView);

grid.ShowAllElements();

Console.WriteLine("\nClicking elements:");
button.Click();
dropDown.Click();

Console.WriteLine("\nResizing elements:");
button.Resize(150, 60);
textView.Resize(250, 70);

Console.WriteLine("\nChanging text:");
textView.SetText("New text");

Console.WriteLine(textView);

Console.WriteLine("\nSelecting an option:");
dropDown.SelectItem("Option 2");

Console.WriteLine("\nChecking resize:");
Console.WriteLine(grid.NeedResize(3, 3));

grid.Resize(1000, 800);

Console.WriteLine("\nFinal grid:");
grid.ShowAllElements();
