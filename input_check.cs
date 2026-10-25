class InputCheck
{
    public static bool Check(string? input, char[] Board, out int cellIndex, out string error)
    {
        cellIndex = -1;
        error = "";

        if (!int.TryParse(input, out int cellNumber))
        {
            error = "Введите целое число. ";
            return false;
        }
        if (cellNumber < 1 || cellNumber > 9)
        {
            error = "Введите номер клетки от 1 до 9. ";
            return false;
        }
        int index = cellNumber - 1;
        if (Board[index] == 'X' || Board[index] == 'O')
        {
            error = "Эта клетка уже занята. ";
            return false;
        }

        cellIndex = index;
        return true;
    }
}
