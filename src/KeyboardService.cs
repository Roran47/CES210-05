using Raylib_cs;

namespace generalNamespace;
public class KeyboardService
{ 
 

  

    public void checkDirections(Bike bike) {
        playerOneLeft(bike);
        playerOneRight(bike);
        playerOneUp(bike);
        playerOneDown(bike);
       
    }
    public void checkDirections2(Bike bike) {
        playerTwoLeft(bike);
        playerTwoRight(bike);
        playerTwoDown(bike);
        playerTwoUp(bike);
    }

    public void playerOneRight(Bike bike)
    {
        // if(x1<795){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            if(bike.direction != 2) {
                 bike.direction = 0;
            }
           
            //x1+=5;
        }
    }

    public void playerOneLeft(Bike bike)
    {
        // if(x1<795){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
             if(bike.direction != 0) {
             bike.direction = 2;
             }
        }
    }

     public void playerOneUp(Bike bike)
     {
        // if(x1<795){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
             if(bike.direction != 1) {
              bike.direction = 3;
             }
         }
     }
     public void playerOneDown(Bike bike)
     {
         // if(x1<795){
         if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
             if(bike.direction != 3) {
               bike.direction = 1;
             }
         }
     }

//Player 2
     public void playerTwoDown(Bike bike)
     {
         // if(x1<795){
         if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
         {
             bike.direction = 1;
         }
     }

         public void playerTwoUp(Bike bike)
     {
         // if(x1<795){
         if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
         {
             bike.direction = 3;
         }
     }

            public void playerTwoLeft(Bike bike)
    {
        // if(x1<795){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            bike.direction = 2;
        }
    }

            public void playerTwoRight(Bike bike)
    {
        // if(x1<795){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            bike.direction = 0;
        }
    }
}