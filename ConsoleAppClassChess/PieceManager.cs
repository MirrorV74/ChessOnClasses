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
        
        public Piece ReturnPiece(int currentMoveStartPosition)
        {
            Piece piece = new Piece(404, 0, 0, "0", "0", false, ConsoleColor.Red);

            for (int i = 0; i < _pieces.Length; i++)
            {
                if (_pieces[i]._coordinateY == currentMoveStartPosition%10 && _pieces[i]._coordinateX == currentMoveStartPosition/10)
                {
                    piece = _pieces[i];
                    break;
                }
            }
            return piece;
        }

        public void ChangePiecePosition(Piece currentPiece, int currentMoveEndPosition)
        {
            for (int i = 0; i < _pieces.Length; i++)
            {
                if (_pieces[i]._coordinateX == currentPiece._coordinateX && _pieces[i]._coordinateY == currentPiece._coordinateY)
                {
                    _pieces[i]._coordinateY = currentMoveEndPosition%10;
                    _pieces[i]._coordinateX = currentMoveEndPosition/10;
                    _pieces[i]._moved = currentPiece._moved;
                    break;
                }
            }
        }

        public void DeletePiece(int currentMoveEndPosition)
        {
            for (int i = 0; i < _pieces.Length; i++)
            {
                if (_pieces[i]._coordinateX == currentMoveEndPosition/10 && _pieces[i]._coordinateY == currentMoveEndPosition%10)
                {
                    _pieces[i] = null;
                    break;
                }
            }
        }
        
        public int[,] PawnMove(Piece currentPiece, string[,] board)
        {
            int var = 0;
            int[,] attackedTiles = new int[64, 2];
            if (currentPiece._color == ConsoleColor.White)
            {
                var = 1;
            }
            else if (currentPiece._color == ConsoleColor.Black)
            {
                var = -1;
            }

            attackedTiles[0, 0] = currentPiece._coordinateY - 1 * var;
            attackedTiles[0, 1] = currentPiece._coordinateX;
            attackedTiles[1, 0] = currentPiece._coordinateY - 2 * var;
            attackedTiles[1, 1] = currentPiece._coordinateX;

            if (board[currentPiece._coordinateY - 1 * var,currentPiece._coordinateX] == Tile.Empty)
            {
                attackedTiles[0, 0] = currentPiece._coordinateY - 1 * var;
                attackedTiles[0, 1] = currentPiece._coordinateX;
            }
            if (board[currentPiece._coordinateY - 2 * var,currentPiece._coordinateX] == Tile.Empty && currentPiece._moved == false)
            {
                attackedTiles[1, 0] = currentPiece._coordinateY - 2 * var;
                attackedTiles[1, 1] = currentPiece._coordinateX;
            }

            currentPiece._moved = true;
            return attackedTiles;
        }
        
        public int[,] RookMove(Piece currentPawn)
        {
            int[,] attackedTiles = new int[64, 2];

            return attackedTiles;
        }

         public void TestPrint()
         {
             for (int i = 0; i < _pieces.Length; i++)
             {
                 Console.WriteLine(_pieces[i]);
             }
         }
    }
}