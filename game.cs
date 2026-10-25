using System.Data;

class Game
{
    public static void Run()
    {
        char[] Board = new char[9];
        char currentPlayer = 'X';

        do
        {
            Restart.Reset(Board, ref currentPlayer);
            Display.Print(Board);

            while (true)
            {
                Console.Write($"Ход игрока {currentPlayer}. Введите клетку (1–9): ");
                string? input = Console.ReadLine();

                if (input == null)
                {
                    return;
                }

                if (!Rules.MakeMove(input, Board, ref currentPlayer, out string error))
                {
                    Console.WriteLine(error);
                    continue;
                }

                Display.Print(Board);

                char winner = Win.Check(Board);

                if (winner != '\0')
                {
                    Console.WriteLine($"Победил игрок {winner}!");
                    break;
                }

                if (Draw.Check(Board))
                {
                    Console.WriteLine("Ничья!");
                    break;
                }
            }
        }
        while (Restart.Ask());
    }
}
