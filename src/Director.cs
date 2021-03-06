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
     public static bool collided = false;
     public void startGame()
    {
        TheGrid theGrid = new TheGrid();
        KeyboardService keyb = new();
        theGrid.makeGrid();
        KeyboardService keyboardService = new KeyboardService();
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
            keyb.checkDirections2(player2);
            if(action) {
                 Raylib.BeginDrawing();
                  vd.draw(theGrid.getGrid());
                  if(collided == false){
                    player1.moveBike();
                    player2.moveBike();
                  }
                  vd.drawBike(player1);
                  vd.drawBike(player2);
                  if(Collision.checkCollision(player1,theGrid.getGrid())) {
                      collided = true;
                      vd.gameOver();
                  }else {

                  }
                   if(  Collision.checkCollision(player2,theGrid.getGrid())) {
                       collided = true;
                       vd.gameOver();
                   }else {

                   }
                
                  action = false;
                  Raylib.EndDrawing();
                  
            }
          
        }
        
    }
     static void SetTimer() {
            timer = new System.Timers.Timer(50);

            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        static void OnTimedEvent(Object source, ElapsedEventArgs e) {
            action = true;
        }
}