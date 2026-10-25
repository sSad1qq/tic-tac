class Restart
{
    public static void Reset(char[] Board, ref char currentPlayer)
    {
        for (int i = 0; i < Board.Length; ++i)
        {
            Board[i] = (char)('1' + i);
        }
        currentPlayer = 'X';
    }
    public static bool Ask()
    {
        while (true)
        {
            Console.Write("Начать новую игру? (да/нет): ");
            string? answer = Console.ReadLine();

            if (answer == null)
            {
                return false;
            }

            answer = answer.Trim().ToLowerInvariant();

            if (answer == "да")
            {
                return true;
            }
            if (answer == "нет")
            {
                return false;
            }

            Console.WriteLine("Введите 'да' или 'нет'. ");
        }
    }
}
