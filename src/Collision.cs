using System;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace generalNamespace;

public static class Collision
{
    public static bool checkCollision(Bike player, List<List<Square>> thegrid)
    {
        int squareX = player.bikeX / 5;
        int squareY = player.bikeY / 5;
        if(thegrid[squareX][squareY].squareColor.Equals(BLACK)){
            return false;
            
        }else{
            return true;
        }
    }
}
