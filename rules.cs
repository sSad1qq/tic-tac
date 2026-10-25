class Rules
{
    public static bool MakeMove(string? input, char[] Board, ref char CurrentPlayer, out string error)
    {
        if (!InputCheck.Check(input, Board, out int cellIndex, out error))
        {
            return false;
        }
        Board[cellIndex] = CurrentPlayer;

        if (CurrentPlayer == 'X')
        {
            CurrentPlayer = 'O';
        }
        else
        {
            CurrentPlayer = 'X';
        }
        return true;
    }
}
