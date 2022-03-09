using System;
using System.Timers;
using Raylib_cs;
namespace generalNamespace;
using System.Timers;
using static Raylib_cs.Color;

public class Director
{
       private static System.Timers.Timer timer;
     static bool action = false;
     public void startGame()
    {
        TheGrid theGrid = new TheGrid();
        theGrid.makeGrid();
        Bike player1 = new Bike();
        Bike player2 = new Bike();
        player1.changeColor(BLUE);
         player2.changeColor(RED);
        var vd = new VideoService();
        Raylib.InitWindow(1000, 1000, "norT");
         SetTimer();
         while (!Raylib.WindowShouldClose())
        {
            if(action) {
                  vd.draw(theGrid.getGrid());
                  action = false;
            }
          
        }
        
    }
     static void SetTimer() {
            timer = new System.Timers.Timer(20);

            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        static void OnTimedEvent(Object source, ElapsedEventArgs e) {
            action = true;
        }
}