using System;
using System.Timers;
using Raylib_cs;
namespace generalNamespace;

public class Director
{
     public void startGame()
    {
        var vd = new VideoService();
        Raylib.InitWindow(1000, 1000, "SnakeTron");
         while (!Raylib.WindowShouldClose())
        {
            vd.draw();
        }
        
    }
}