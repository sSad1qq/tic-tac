class Draw
{
    public static bool Check(char[] Board)
    {
        if (Win.Check(Board) != '\0')
        {
            return false;
        }

        for (int i = 0; i < Board.Length; ++i)
        {
            if (Board[i] != 'X' && Board[i] != 'O')
            {
                return false;
            }
        }

        return true;
    }
}
