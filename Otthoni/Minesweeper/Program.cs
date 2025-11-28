using System;
using Minesweeper;

namespace Minesweeper;
bool going = true;
while (going)
{
    Console.WriteLine("Difficulty: [1], [2], [3],");
    Console.WriteLine("[c] or [C] for custom,");
    Console.WriteLine("[e] or [E] to exit.");
    Console.Write("> ");
    string? command=Console.ReadLine();
    command=command.ToLower();
    Board board;
    switch (command)
    {
        case "1":
            board = new Board(14, 9);
            board.fill(15)
            break;
        case "2":
            board = new Board(20, 15);
            board.fill(40)
            break;
        case "3":
            board = new Board(26, 19);
            board.fill(90)
            break;
        case "c":
            Console.Write("Height: ");
            string? x = Console.ReadLine();
            Console.Write("Width: ");
            string? y = Console.ReadLine();
            Console.Write("Mines: ");
            string? m = Console.ReadLine();
            try
            {
                if (Int32.Parse(m)>Int32.Parse(x)*Int32.Parse(y))
                {
                    throw new Exception();
                }
                board=new Board(Int32.Parse(x), Int32.Parse(y));
                board.fill(m);
            }
            catch (Exception e)
            {
                Console.WriteLine("The parameters you gave aren't right!");
            }
            break;
        case "e":
            going = false;
            break;
        default:
            Console.Write("I didn't get that.");
}