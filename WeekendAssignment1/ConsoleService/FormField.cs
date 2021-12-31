using System;

namespace WeekendAssignment1.ConsoleService;

internal class FormField
{
    public string Name { get; set; }
    public string Value { get; set; }
    public int Left { get; set; }
    public int Top { get; set; }
    public int ValueLeft { get; set; }
    public int ValueWidth { get; set; }


    public FormField(string name, int left, int top, int valueLeft, int valueWidth)
    {
        Name = name;
        Left = left;
        Top = top;

        ValueLeft = valueLeft;
        ValueWidth = valueWidth;
    }

    public void Display(int formLeft, int formTop)
    {
        Console.SetCursorPosition(formLeft + Left, formTop + Top);
        Console.Write($"{Name}: {new string('_', ValueWidth)}");
    }
}
