using ConsoleAppClassChess;

PieceManager pieceManager = new PieceManager();

string[,] Empty()
{
    string[,] board = new String[9, 9];

    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            board[i, j] = Tile.Empty;
        }
    }

    return board;
}

void NumberColumn(string[,] board)
{
    int counter = 8;
    for (int i = 0; i < 8; i++)
    {
        board[i, 8] = $" {counter} ";
        counter--;
    }
}

void LetterRow(string[,] board)
{
    board[8, 8] = "   ";
    board[8, 0] = " A ";
    board[8, 1] = " B ";
    board[8, 2] = " C ";
    board[8, 3] = " D ";
    board[8, 4] = " E ";
    board[8, 5] = " F ";
    board[8, 6] = " G ";
    board[8, 7] = " H ";
}

string ConvertMove(string move)
{
    bool moveIsCorrect = true;
    while (moveIsCorrect)
    {
        char row = move[1];
        switch (row)
        {
            case '1':
            {
                move = move.Replace("1", "7");
                return move;
            }
            case '2':
            {
                move = move.Replace("2", "6");
                return move;
            }
            case '3':
            {
                move = move.Replace("3", "5");
                return move;
            }
            case '4':
            {
                move = move.Replace("4", "4");
                return move;
            }
            case '5':
            {
                move = move.Replace("5", "3");
                return move;
            }
            case '6':
            {
                move = move.Replace("6", "2");
                return move;
            }
            case '7':
            {
                move = move.Replace("7", "1");
                return move;
            }
            case '8':
            {
                move = move.Replace("8", "0");
                return move;
            }
            default:
            {
                Console.WriteLine("Incorrect wording. Try again!");
                moveIsCorrect = false;
                break;
            }
        }
    }

    moveIsCorrect = true;
    while (moveIsCorrect)
    {
        char column = move.ToLower()[0];
        switch (column)
        {
            case 'a':
            {
                move = move.Replace("a", "o");
                return move;
            }
            case 'b':
            {
                move = move.Replace("b", "1");
                return move;
            }
            case 'c':
            {
                move = move.Replace("c", "2");
                return move;
            }
            case 'd':
            {
                move = move.Replace("d", "3");
                return move;
            }
            case 'e':
            {
                move = move.Replace("e", "4");
                return move;
            }
            case 'f':
            {
                move = move.Replace("f", "5");
                return move;
            }
            case 'g':
            {
                move = move.Replace("g", "6");
                return move;
            }
            case 'h':
            {
                move = move.Replace("h", "7");
                return move;
            }
            default:
            {
                Console.WriteLine("Incorrect wording");
                moveIsCorrect = false;
                break;
            }
        }
    }

    return move;
}

void Move()
{
    string currentMoveStartPosition = Console.ReadLine();
    currentMoveStartPosition = ConvertMove(currentMoveStartPosition);

    string currentMoveEndPosition = Console.ReadLine();
    currentMoveEndPosition = ConvertMove(currentMoveEndPosition);
}

string[,] FillingTheBoard()
{
    string[,] board = Empty();
    NumberColumn(board);
    LetterRow(board);
    return board;
}

string[,] board = FillingTheBoard();

pieceManager.GeneratePieces();
pieceManager.RefreshBoard(board);
pieceManager.PrintBoard(board);

//pieceManager.TestPrint();