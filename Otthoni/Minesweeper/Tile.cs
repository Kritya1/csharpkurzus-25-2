using System;

namespace Minesweeper;
class Tile
{
    private bool isMine;
    private int number;
    private bool isHidden;
    private bool flag;
    public Tile()
    {
        isMine = false;
        number = 0;
        isHidden = true;
        flag= false;
    }
    public void makeIntoMine()
    {
        isMine = true;
    }
    public bool isMine()
    {
        return isMine;
    }
    public void increaseNumber()
    {
        this.number++;
    }
    public char print()
    {
        if (isHidden)
        {
            return '#';
        }
        if (number>0)
        {
            return (char)number;
        }
        return ' ';
    }
    public isHidden()
    {
        return isHidden;
    }
    public void reveal()
    {
        isHidden = false;
        flag = false;
    }
    public void flag()
    {
        flag = !flag;
    }
}