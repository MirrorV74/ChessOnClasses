namespace ConsoleAppClassChess
{
    class PieceManager
    {
        private Piece[] _pieces;

        private int _globalPieceId;

        public PieceManager()
        {
            _pieces = new Piece[32];
            _globalPieceId = 0;
        }

        public void GeneratePieces()
        {
            for (int i = 0; i < _pieces.Length; i++)
            {
                _globalPieceId++;
                int id = _globalPieceId;
                bool moved = false;
                int coordinateX = i % 8;
                int coordinateY = 0; //Какая-то херня потом пофиксить
                string type = "error";
                string consoleChar = " a ";
                ConsoleColor color;
                if (i < 16)
                {
                    color = ConsoleColor.White;
                }
                else
                {
                    color = ConsoleColor.Black;
                }

                if (i < 8)
                {
                    coordinateY = 7;
                }

                if (i > 7 && i < 16)
                {
                    coordinateY = 6;
                    type = "pawn";
                    consoleChar = Tile.WhitePawn;
                }

                if (i > 23)
                {
                    coordinateY = 0;
                }

                if (i > 15 && i < 24)
                {
                    coordinateY = 1;
                    type = "pawn";
                    consoleChar = Tile.BlackPawn;
                }

                if (i == 0 || i == 7)
                {
                    consoleChar = Tile.WhiteRook;
                    type = "rook";
                }

                if (i == 24 || i == 31)
                {
                    consoleChar = Tile.BlackRook;
                    type = "rook";
                }

                if (i == 1 || i == 6)
                {
                    consoleChar = Tile.WhiteKnight;
                    type = "knight";
                }

                if (i == 25 || i == 30)
                {
                    consoleChar = Tile.BlackKnight;
                    type = "knight";
                }

                if (i == 2 || i == 5)
                {
                    consoleChar = Tile.WhiteBishop;
                    type = "bishop";
                }

                if (i == 26 || i == 29)
                {
                    consoleChar = Tile.BlackBishop;
                    type = "bishop";
                }

                if (i == 4)
                {
                    consoleChar = Tile.WhiteKing;
                    type = "king";
                }

                if (i == 28)
                {
                    consoleChar = Tile.BlackKing;
                    type = "king";
                }

                if (i == 3)
                {
                    consoleChar = Tile.WhiteQueen;
                    type = "queen";
                }

                if (i == 27)
                {
                    consoleChar = Tile.BlackQueen;
                    type = "queen";
                }

                _pieces[i] = new Piece(id, coordinateX, coordinateY, consoleChar, type, moved, color);
            }
        }

        public void RefreshBoard(string[,] board)
        {
            for (int i = 0; i < _pieces.Length; i++)
            {
                board[_pieces[i]._coordinateY, _pieces[i]._coordinateX] = _pieces[i]._consoleChar;
            }
        }

        public void PrintBoard(string[,] board)
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
        }

        // public void TestPrint()
        // {
        //     for (int i = 0; i < _pieces.Length; i++)
        //     {
        //         Console.WriteLine(_pieces[i]);
        //     }
        // }
    }
}