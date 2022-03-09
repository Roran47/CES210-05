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

    public void playerOneRight()
    {
        // if(x1<795){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            
        }
    }

    public void playerOneLeft()
    {
        // if(x1<795){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            //
        }
    }

    // public void playerOneUp()
    // {
    //     // if(x1<795){
    //     if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
    //     {
    //         //
    //     }
    // }
    // public void playerOneDown()
    // {
    //     // if(x1<795){
    //     if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
    //     {
    //         //
    //     }
    // }

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

            public void playerTwoLeft()
    {
        // if(x1<795){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            //
        }
    }

            public void playerTwoRight()
    {
        // if(x1<795){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            //
        }
    }
}