class Win
{
    public static char Check(char[] Board)
    {
        int[,] Lines =
        {
            { 0, 1, 2} ,
            { 3, 4, 5 },
            { 6, 7, 8 },
            { 0, 3, 6 },
            { 1, 4, 7 },
            { 2, 5, 8 },
            { 0, 4, 8 },
            { 2, 4, 6 }
        };

        for (int i = 0; i < Lines.GetLength(0); ++i)
        {
            int first = Lines[i, 0];
            int second = Lines[i, 1];
            int third = Lines[i, 2];

            char symbol = Board[first];

            if ((symbol == 'X' || symbol == 'O') &&
                symbol == Board[second] &&
                symbol == Board[third])
            {
                return symbol;
            }
        }

        return '\0';
    }
}
