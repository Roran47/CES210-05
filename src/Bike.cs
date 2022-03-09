using System;
using Raylib_cs;
using static Raylib_cs.Color;

namespace generalNamespace;

public class Bike
{
    public int bikeX = 50;
    public int bikeY = 50;
    public int bikeWidth = 5;
    public int bikeHeight = 5;
    public Color bikeColor = BLUE;
    public void changeColor(Color color)
    {
       bikeColor = color;
    }
    public void setX(int x) {
        bikeX = x;
    }
    public void setY(int y) {
        bikeX = y;
    }

}