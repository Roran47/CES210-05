using Raylib_cs;

namespace generalNamespace;
public class KeyboardService
{ 
    // Up = 0, Right = 1, Down = 2, Left = 3
    public int playerOneDirection = 1;
    public int playerTwoDirection = 0;
    
    // Change player 1 movement
    public void movePlayerOne()
    {
        if(Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            if(playerOneDirection < 3)
                playerOneDirection ++;
            else if(playerOneDirection >= 3)
                playerOneDirection = 0;
        }
        else if(Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            if(playerOneDirection > 0)
                playerOneDirection --;
            else if(playerOneDirection <= 0)
                playerOneDirection = 3;
        }
    }

    // Return player 1 direction
    public int getPlayerOneDirection(int playerOneDirection)
    {
        return playerOneDirection;
    }

    // Change player 2 direction
    public void movePlayerTwo()
    {
        if(Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            if(playerTwoDirection < 3)
                playerTwoDirection ++;
            else if(playerTwoDirection >= 3)
                playerTwoDirection = 0;
        }
        else if(Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            if(playerTwoDirection > 0)
                playerTwoDirection --;
            else if(playerTwoDirection <= 0)
                playerTwoDirection = 3;
        }
    }

    // Return player 2 direction
    public int getPlayerTwoDirection(int playerTwoDirection)
    {
        return playerTwoDirection;
    }

    public void checkDirections(Bike bike) {
        playerOneLeft(bike);
        playerOneRight(bike);
        playerOneUp(bike);
        playerOneDown(bike);
        playerTwoLeft(bike);
        playerTwoRight(bike);
    }

    public void playerOneRight(Bike bike)
    {
        // if(x1<795){
        if (Raylib.IsKeyReleased(KeyboardKey.KEY_D))
        {
            
            bike.direction = 0;
            //x1+=5;
        }
    }

    public void playerOneLeft(Bike bike)
    {
        // if(x1<795){
        if (Raylib.IsKeyReleased(KeyboardKey.KEY_A))
        {
             bike.direction = 2;
        }
    }

     public void playerOneUp(Bike bike)
     {
        // if(x1<795){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
              bike.direction = 3;
         }
     }
     public void playerOneDown(Bike bike)
     {
         // if(x1<795){
         if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
               bike.direction = 1;
         }
     }

//Player 2
    // public void playerTwoDown()
    // {
    //     // if(x1<795){
    //     if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
    //     {
    //         //
    //     }
    // }

    //     public void playerTwoUp()
    // {
    //     // if(x1<795){
    //     if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
    //     {
    //         //
    //     }
    // }

            public void playerTwoLeft(Bike bike)
    {
        // if(x1<795){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            //
        }
    }

            public void playerTwoRight(Bike bike)
    {
        // if(x1<795){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            //
        }
    }
}