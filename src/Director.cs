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
        KeyboardService keyb = new();
        theGrid.makeGrid();
        KeyboardService keyboardService = new KeyboardService();
        keyboardService.playerOneDirection = 1;    // Down
        keyboardService.playerTwoDirection = 0;    // Up
        Bike player1 = new Bike();
        Bike player2 = new Bike();
        player1.setX(200);
        player1.setY(200);
        player1.changeColor(BLUE);
        player2.setX(800);
        player2.setY(800);
         player2.changeColor(RED);
        var vd = new VideoService();
        Raylib.InitWindow(1000, 1000, "norT");
         SetTimer();
         while (!Raylib.WindowShouldClose())
        {
            keyb.checkDirections(player1);
            keyb.checkDirections(player2);
            if(action) {
                 Raylib.BeginDrawing();
                  vd.draw(theGrid.getGrid());
                  player1.moveBike();
                //  player2.moveBike();
                  vd.drawBike(player1);
                  vd.drawBike(player2);
                  if(Collision.checkCollision(player1,theGrid.getGrid())) {
                      //timer.Dispose();
                      // Call Gameover Method
                  }
                   if(  Collision.checkCollision(player2,theGrid.getGrid())) {
                      //timer.Dispose();
                       // Call Gameover Method
                   }
                
                  action = false;
                  Raylib.EndDrawing();
                  keyboardService.movePlayerOne();
                  keyboardService.movePlayerTwo();
            }
          
        }
        
    }
     static void SetTimer() {
            timer = new System.Timers.Timer(100);

            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        static void OnTimedEvent(Object source, ElapsedEventArgs e) {
            action = true;
        }
}