using System;

namespace generalNamespace;

public class TheGrid
{
    public int screenWidth = 1000;
    public int screenHeight = 1000;

    public List<List<Square>> grid = new List<List<Square>>();
    public List<List<Square>> getGrid()
    {
        return grid;
    }

    public void makeGrid()
    {
        for(int i = 0; i <= screenWidth / 5; i++)
        {
            List<Square> tempGrid = new List<Square>();
            for(int j = 0; j <= screenHeight / 5; j++)
            {
                Square square = new Square();
                square.x = i * 5;
                square.y = j * 5;
                tempGrid.Add(square);
            }
            grid.Add(tempGrid);
        }
    }
}