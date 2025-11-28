using System;
using Minesweeper;

namespace Minesweeper;
class Board
{
    private Tile[,] tiles;
    private int x, y;
    public Board(int x, int y)
    {
        tiles=new Tile[x,y];
        for (int i=0; i<x; i++)
        {
            for (int j=0; j<y; j++)
            {
                tiles[i][j] = new Tile();
            }
        }
        this.x = x;
        this.y = y;
    }
    public void print()
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write(tiles[i][j].print());
            }
            Console.WriteLine();
        }
    }
    public fill(int mines)
    {
        Random rnd = new Random();
        while (mines>0)
        {
            int x = rnd.Next(0, this.x);
            int y=rnd.Next(0, this.y);
            if (tiles[x][y].isMine)
            {
                continue;
            }
            tiles[x][y].makeIntoMine;
            for (int i=-1; i<2; i++)
            {
                for (int j=-1; j<2; j++)
                {
                    if (x+i>=0 && x+i<this.x && y+j>=0 && y+j<this.y)
                    {
                        tiles[x + i][y + j].increaseNumber();
                    }
                }
            }
            mines--;
        }
        print();
    }
    public void leftClick(int x, int y)
    {
        if (tiles[x][y].isFlagged())
        {
            Console.WriteLine("That's flagged.");
        }
        else if (tiles[x][y].isHidden())
        {
            tiles[x][y].reveal();
            print();
        }
        else
        {
            Console.WriteLine("Already removed!");
        }
    }
    public void rightClick(int x, int y)
    {
        if (tiles[x][y].isHidden())
        {
            tiles[x][y].flag();
            print();
        }
        else
        {
            Console.WriteLine("Already removed!");
        }
    }
}