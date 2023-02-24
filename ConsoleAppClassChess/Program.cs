using ConsoleAppClassChess;

PieceManager pieceManager = new PieceManager();

string[,] Empty()
{
    string[,] board = new String[9, 9];

    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            board[i, j] = TileChar.Empty;
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

Tile ConvertMove(string move)
{
    bool moveIsCorrect;
    do
    {
        moveIsCorrect = true;

        char row = move[1];
        switch (row)
        {
            case '1':
            {
                move = move.Replace("1", "7");
                break;
            }
            case '2':
            {
                move = move.Replace("2", "6");
                break;
            }
            case '3':
            {
                move = move.Replace("3", "5");
                break;
            }
            case '4':
            {
                move = move.Replace("4", "4");
                break;
            }
            case '5':
            {
                move = move.Replace("5", "3");
                break;
            }
            case '6':
            {
                move = move.Replace("6", "2");
                break;
            }
            case '7':
            {
                move = move.Replace("7", "1");
                break;
            }
            case '8':
            {
                move = move.Replace("8", "0");
                break;
            }
            default:
            {
                Console.WriteLine("Incorrect wording. Try again!");
                moveIsCorrect = false;
                break;
            }
        }

        char column = move.ToLower()[0];
        switch (column)
        {
            case 'a':
            {
                move = move.Replace("a", "0");
                break;
            }
            case 'b':
            {
                move = move.Replace("b", "1");
                break;
            }
            case 'c':
            {
                move = move.Replace("c", "2");
                break;
            }
            case 'd':
            {
                move = move.Replace("d", "3");
                break;
            }
            case 'e':
            {
                move = move.Replace("e", "4");
                break;
            }
            case 'f':
            {
                move = move.Replace("f", "5");
                break;
            }
            case 'g':
            {
                move = move.Replace("g", "6");
                break;
            }
            case 'h':
            {
                move = move.Replace("h", "7");
                break;
            }
            default:
            {
                Console.WriteLine("Incorrect wording. Try again!");
                moveIsCorrect = false;
                break;
            }
        }
    } while (!moveIsCorrect);

    int moveI = Int32.Parse(move);
    Tile current = new Tile();
    current.X = moveI / 10;
    current.Y = moveI % 10;
    return current;
}

void Move(string[,] board)
{
    string currentMoveStartPosition = Console.ReadLine();
    Tile currentStart = ConvertMove(currentMoveStartPosition);

    Piece currentPiece = pieceManager.ReturnPiece(currentStart);
    
    Console.WriteLine(currentPiece);

    int[,] attackedTiles = new int[64, 2];

    string currentMoveEndPosition = Console.ReadLine();
    Tile currentEnd = ConvertMove(currentMoveEndPosition);

    switch (currentPiece._type)
    {
        case "pawn":
        {
            attackedTiles = pieceManager.PawnMove(currentPiece, board);
            // for (int i = 0; i < attackedTiles.GetLength(0); i++)
            // {
            //     if (!(attackedTiles[i, 0] == 0 && attackedTiles[i, 1] == 0))
            //     {
            //         Console.WriteLine($"{attackedTiles[i, 0]} {attackedTiles[i, 1]}");
            //     }
            // } 

            break;
        }
        case "bishop":
        {
            break;
        }
        case "knight":
        {
            break;
        }
        case "king":
        {
            break;
        }
        case "queen":
        {
            break;
        }
        case "rook":
        {
            break;
        }
    }

    for (int i = 0; i < attackedTiles.GetLength(1); i++)
    {
        if (currentEnd.Y == attackedTiles[i, 0] && currentEnd.X == attackedTiles[i, 1])
        {
            pieceManager.DeletePiece(currentEnd);
            pieceManager.ChangePiecePosition(currentPiece, currentEnd);

            board[currentStart.Y, currentStart.X] = TileChar.Empty;

            break;
        }
    }
}

string[,] FillingTheBoard()
{
    string[,] board = Empty();
    NumberColumn(board);
    LetterRow(board);
    return board;
}

void PrintBoard(string[,] board)
{
    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            if ((i + j) % 2 == 0)
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }

            if (i == 8 || j == 8)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }

            Console.Write(board[i, j]);
        }
        Console.WriteLine();
    }
    Console.ResetColor();
}

pieceManager.GeneratePieces();
string[,] board = FillingTheBoard();
for (int i = 0; i < 3; i++)
{
    Console.Clear();
    pieceManager.RefreshBoard(board);
    PrintBoard(board);
    Move(board);
}
