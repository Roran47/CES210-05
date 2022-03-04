using System;
using Raylib_cs;
using static Raylib_cs.Color;

namespace generalNamespace;

public class Square
{
    public int squareWidth = 5;
    public int squareHeight = 5;

    public int x = 0;
    public int y = 0;
    public Color squareColor = BLACK;

    public void changeColor(Color color)
    {
        squareColor = color;
    }
}