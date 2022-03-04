using Raylib_cs;

namespace generalNamespace;
public class keyboard_service
{

    public void playerOneRight()
    {
        // if(x1<795){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            //x1+=5;
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

    public void playerOneUp()
    {
        // if(x1<795){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            //
        }
    }
    public void playerOneDown()
    {
        // if(x1<795){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            //
        }
    }

//Player 2
    public void playerTwoDown()
    {
        // if(x1<795){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
        {
            //
        }
    }

        public void playerTwoUp()
    {
        // if(x1<795){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
        {
            //
        }
    }

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