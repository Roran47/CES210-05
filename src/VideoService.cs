using System;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace generalNamespace;

public class VideoService
{
    int scrnWidth = 1000;
    int scrnHeight = 1000;
     public void draw(List<List<Square>> grid)
    {
        Raylib.BeginDrawing();
         Raylib.ClearBackground(Color.BLACK);
            for(int i = 0; i <= scrnWidth / 5; i++)
            {
                for(int j = 0; j <= scrnHeight / 5; j++)
                {
                    DrawRectangle(grid[i][j].x, grid[i][j].y, grid[i][j].squareWidth, grid[i] [j].squareHeight, grid[i][j].squareColor);
                }
            }
            Raylib.EndDrawing();
        
    }
    public void drawBike(Bike bike) {
       DrawRectangle(bike.bikeX,bike.bikeY,bike.bikeWidth,bike.bikeHeight,bike.bikeColor);
    }
}