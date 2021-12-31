using System;
using System.Reflection.Emit;

namespace WeekendAssignment1.ConsoleService;

internal class FormField
{
    public string Name { get; }
    public string Value { get; private set; }
    public int Left { get; }
    public int Top { get; }
    public int ValueWidth { get; }
    public string Label { get; }

    public FormField(string name, int left, int top, int valueWidth)
    {
        Name = name;
        Left = left;
        Top = top;
        ValueWidth = valueWidth;
        Label = Name;
    }

    public FormField(string name, int left, int top, int valueWidth, string label)
    {
        Name = name;
        Left = left;
        Top = top;
        ValueWidth = valueWidth;
        Label = label;
    }

    public void Display(int formLeft, int formTop)
    {
        Console.SetCursorPosition(formLeft + Left, formTop + Top);
        Console.Write($"{Label}: {new string('_', ValueWidth)}");
    }

    public void Input(int formLeft, int formTop)
    {
        Console.SetCursorPosition(formLeft + Left + Name.Length + 2, formTop + Top);
        Value = Console.ReadLine();
    }
}
