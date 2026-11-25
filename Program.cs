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

Console.WriteLine();
Console.WriteLine("All elements:");
grid.ShowAllElements();

Console.WriteLine();
Console.WriteLine("Adding element to occupied position:");
grid.AddToGrid(button, 0, 0);

Console.WriteLine();
Console.WriteLine("Deleting element:");
grid.DeleteFromGrid(textView);

grid.ShowAllElements();

Console.WriteLine();
Console.WriteLine("Clicking elements:");
button.Click();
dropDown.Click();

Console.WriteLine();
Console.WriteLine("Resizing elements:");
button.Resize(150, 60);
textView.Resize(250, 70);

Console.WriteLine();
Console.WriteLine("Changing text:");
textView.SetText("New text");

Console.WriteLine(textView);

Console.WriteLine();
Console.WriteLine("Selecting an option:");
dropDown.SelectItem("Option 2");

Console.WriteLine();
Console.WriteLine("Checking resize:");
Console.WriteLine(grid.NeedResize(3, 3));

grid.Resize(1000, 800);

Console.WriteLine();
Console.WriteLine("Final grid:");
grid.ShowAllElements();
