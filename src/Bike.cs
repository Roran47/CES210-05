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

    public int direction = 0;
    public virtual void changeColor(Color color)
    {
        bikeColor = color;
    }
    public void setX(int x)
    {
        bikeX = x;
    }
    public void setY(int y)
    {
        bikeX = y;
    }

    public virtual void moveBike()
    {
      


        switch (direction)
        {
            case 0:
             if (bikeX == 995)
                {
                    Director.collided = true;
                }
                else
                {
                bikeX += 5;
                }
                break;

            case 1:
             if (bikeY == 995)
                {
                    Director.collided = true;
                }
                else
                {
                bikeY += 5;
                }
                break;

            case 2:
                if (bikeX == 0)
                {
                    Director.collided = true;
                }
                else
                {
                    bikeX -= 5;
                }

                break;

            case 3:
             if (bikeY == 0)
                {
                    Director.collided = true;
                }
                else
                {
                bikeY -= 5;
                }
                break;
        }
    }

}