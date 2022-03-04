using System;
using System.Timers;
using Raylib_cs;
namespace generalNamespace;

public class Director
{
     public void startGame()
    {
        TheGrid theGrid = new TheGrid();
        theGrid.makeGrid();
        var vd = new VideoService();
        Raylib.InitWindow(1000, 1000, "norT");
         while (!Raylib.WindowShouldClose())
        {
            vd.draw(theGrid.getGrid());
        }
        
    }
}