class Display
{
    public static void Print(char[] Board)
    {
        Console.WriteLine();
        Console.WriteLine($" {Board[0]} | {Board[1]} | {Board[2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {Board[3]} | {Board[4]} | {Board[5]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {Board[6]} | {Board[7]} | {Board[8]} ");
        Console.WriteLine();
    }
}
