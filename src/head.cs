using System;
using Raylib_cs;
using static Raylib_cs.Color;

namespace generalNamespace;

public class head : Bike 
{
    public override void changeColor(Color color)
    {
        bikeColor = color;
    }
    public override void moveBike() {
        bikeX +=5;
        bikeY += 5;
    }
    public override void moveX() {
        bikeX += 10;
    }
    public override void moveY() {
        bikeY += 10;
    }
    
}