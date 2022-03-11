using Raylib_cs;

namespace generalNamespace;
public class keyboard_service
{

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