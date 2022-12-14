// See https://aka.ms/new-console-template for more information
using Consolegoose_game;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Dice dice = new Dice();
        Console.WriteLine(dice.Throw());

        Player player = new Player("guillaume");
        player.DiceDraw();



    }
}