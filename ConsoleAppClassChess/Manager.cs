namespace ConsoleAppClassChess
{
    class Manager
    {

        void Display(string[,] board, Piece piece)
        {
            board[piece.сoordinateY, piece.сoordinateX] = piece.consoleChar;
        }
        
        public Piece[] PieceInit()
        {
            Piece[] pieces = new Piece[32];

            #region White pieces initialization

            Piece whiteAPawn = new Piece();
            pieces[0] = whiteAPawn;
            whiteAPawn.сoordinateX = 0;
            whiteAPawn.сoordinateY = 6;
            whiteAPawn.color = ConsoleColor.White;
            whiteAPawn.consoleChar = Tile.WhitePawn;
            whiteAPawn.type = "pawn";
            whiteAPawn.moved = false;

            Piece whiteBPawn = new Piece();
            pieces[1] = whiteBPawn;
            whiteBPawn.сoordinateX = 1;
            whiteBPawn.сoordinateY = 6;
            whiteBPawn.color = ConsoleColor.White;
            whiteBPawn.consoleChar = Tile.WhitePawn;
            whiteBPawn.type = "pawn";
            whiteBPawn.moved = false;

            Piece whiteCPawn = new Piece();
            pieces[2] = whiteCPawn;
            whiteCPawn.сoordinateX = 2;
            whiteCPawn.сoordinateY = 6;
            whiteCPawn.color = ConsoleColor.White;
            whiteCPawn.consoleChar = Tile.WhitePawn;
            whiteCPawn.type = "pawn";
            whiteCPawn.moved = false;

            Piece whiteDPawn = new Piece();
            pieces[3] = whiteDPawn;
            whiteDPawn.сoordinateX = 3;
            whiteDPawn.сoordinateY = 6;
            whiteDPawn.color = ConsoleColor.White;
            whiteDPawn.consoleChar = Tile.WhitePawn;
            whiteDPawn.type = "pawn";
            whiteDPawn.moved = false;

            Piece whiteEPawn = new Piece();
            pieces[4] = whiteEPawn;
            whiteEPawn.сoordinateX = 4;
            whiteEPawn.сoordinateY = 6;
            whiteEPawn.color = ConsoleColor.White;
            whiteEPawn.consoleChar = Tile.WhitePawn;
            whiteEPawn.type = "pawn";
            whiteEPawn.moved = false;

            Piece whiteFPawn = new Piece();
            pieces[5] = whiteFPawn;
            whiteFPawn.сoordinateX = 5;
            whiteFPawn.сoordinateY = 6;
            whiteFPawn.color = ConsoleColor.White;
            whiteFPawn.consoleChar = Tile.WhitePawn;
            whiteFPawn.type = "pawn";
            whiteFPawn.moved = false;

            Piece whiteGPawn = new Piece();
            pieces[6] = whiteGPawn;
            whiteGPawn.сoordinateX = 6;
            whiteGPawn.сoordinateY = 6;
            whiteGPawn.color = ConsoleColor.White;
            whiteGPawn.consoleChar = Tile.WhitePawn;
            whiteGPawn.type = "pawn";
            whiteGPawn.moved = false;

            Piece whiteHPawn = new Piece();
            pieces[7] = whiteHPawn;
            whiteHPawn.сoordinateX = 7;
            whiteHPawn.сoordinateY = 6;
            whiteHPawn.color = ConsoleColor.White;
            whiteHPawn.consoleChar = Tile.WhitePawn;
            whiteHPawn.type = "pawn";
            whiteHPawn.moved = false;

            Piece whiteARook = new Piece();
            pieces[8] = whiteARook;
            whiteARook.сoordinateX = 0;
            whiteARook.сoordinateY = 7;
            whiteARook.color = ConsoleColor.White;
            whiteARook.consoleChar = Tile.WhiteRook;
            whiteARook.type = "rook";
            whiteARook.moved = false;

            Piece whiteHRook = new Piece();
            pieces[9] = whiteHRook;
            whiteHRook.сoordinateX = 7;
            whiteHRook.сoordinateY = 7;
            whiteHRook.color = ConsoleColor.White;
            whiteHRook.consoleChar = Tile.WhiteRook;
            whiteHRook.type = "rook";
            whiteHRook.moved = false;

            Piece whiteBKnight = new Piece();
            pieces[10] = whiteBKnight;
            whiteBKnight.сoordinateX = 1;
            whiteBKnight.сoordinateY = 7;
            whiteBKnight.color = ConsoleColor.White;
            whiteBKnight.consoleChar = Tile.WhiteKnight;
            whiteBKnight.type = "knight";

            Piece whiteGKnight = new Piece();
            pieces[11] = whiteGKnight;
            whiteGKnight.сoordinateX = 6;
            whiteGKnight.сoordinateY = 7;
            whiteGKnight.color = ConsoleColor.White;
            whiteGKnight.consoleChar = Tile.WhiteKnight;
            whiteGKnight.type = "knight";

            Piece whiteCBishop = new Piece();
            pieces[12] = whiteCBishop;
            whiteCBishop.сoordinateX = 2;
            whiteCBishop.сoordinateY = 7;
            whiteCBishop.color = ConsoleColor.White;
            whiteCBishop.consoleChar = Tile.WhiteBishop;
            whiteCBishop.type = "bishop";

            Piece whiteFBishop = new Piece();
            pieces[13] = whiteFBishop;
            whiteFBishop.сoordinateX = 5;
            whiteFBishop.сoordinateY = 7;
            whiteFBishop.color = ConsoleColor.White;
            whiteFBishop.consoleChar = Tile.WhiteBishop;
            whiteFBishop.type = "bishop";

            Piece whiteQueen = new Piece();
            pieces[14] = whiteQueen;
            whiteQueen.сoordinateX = 3;
            whiteQueen.сoordinateY = 7;
            whiteQueen.color = ConsoleColor.White;
            whiteQueen.consoleChar = Tile.WhiteQueen;
            whiteQueen.type = "queen";

            Piece whiteKing = new Piece();
            pieces[15] = whiteKing;
            whiteKing.сoordinateX = 4;
            whiteKing.сoordinateY = 7;
            whiteKing.color = ConsoleColor.White;
            whiteKing.consoleChar = Tile.WhiteKing;
            whiteKing.type = "king";
            whiteKing.moved = false;

            #endregion

            #region Black pieces initialization

            Piece blackAPawn = new Piece();
            pieces[16] = blackAPawn;
            blackAPawn.сoordinateX = 0;
            blackAPawn.сoordinateY = 1;
            blackAPawn.color = ConsoleColor.Black;
            blackAPawn.consoleChar = Tile.BlackPawn;
            blackAPawn.type = "pawn";
            blackAPawn.moved = false;

            Piece blackBPawn = new Piece();
            pieces[17] = blackBPawn;
            blackBPawn.сoordinateX = 1;
            blackBPawn.сoordinateY = 1;
            blackBPawn.color = ConsoleColor.Black;
            blackBPawn.consoleChar = Tile.BlackPawn;
            blackBPawn.type = "pawn";
            blackBPawn.moved = false;

            Piece blackCPawn = new Piece();
            pieces[18] = blackCPawn;
            blackCPawn.сoordinateX = 2;
            blackCPawn.сoordinateY = 1;
            blackCPawn.color = ConsoleColor.Black;
            blackCPawn.consoleChar = Tile.BlackPawn;
            blackCPawn.type = "pawn";
            blackCPawn.moved = false;

            Piece blackDPawn = new Piece();
            pieces[19] = blackDPawn;
            blackDPawn.сoordinateX = 3;
            blackDPawn.сoordinateY = 1;
            blackDPawn.color = ConsoleColor.Black;
            blackDPawn.consoleChar = Tile.BlackPawn;
            blackDPawn.type = "pawn";
            blackDPawn.moved = false;

            Piece blackEPawn = new Piece();
            pieces[20] = blackEPawn;
            blackEPawn.сoordinateX = 4;
            blackEPawn.сoordinateY = 1;
            blackEPawn.color = ConsoleColor.Black;
            blackEPawn.consoleChar = Tile.BlackPawn;
            blackEPawn.type = "pawn";
            blackEPawn.moved = false;

            Piece blackFPawn = new Piece();
            pieces[21] = blackFPawn;
            blackFPawn.сoordinateX = 5;
            blackFPawn.сoordinateY = 1;
            blackFPawn.color = ConsoleColor.Black;
            blackFPawn.consoleChar = Tile.BlackPawn;
            blackFPawn.type = "pawn";
            blackFPawn.moved = false;

            Piece blackGPawn = new Piece();
            pieces[22] = blackGPawn;
            blackGPawn.сoordinateX = 6;
            blackGPawn.сoordinateY = 1;
            blackGPawn.color = ConsoleColor.Black;
            blackGPawn.consoleChar = Tile.BlackPawn;
            blackGPawn.type = "pawn";
            blackGPawn.moved = false;

            Piece blackHPawn = new Piece();
            pieces[23] = blackHPawn;
            blackHPawn.сoordinateX = 7;
            blackHPawn.сoordinateY = 1;
            blackHPawn.color = ConsoleColor.Black;
            blackHPawn.consoleChar = Tile.BlackPawn;
            blackHPawn.type = "pawn";
            blackHPawn.moved = false;

            Piece blackARook = new Piece();
            pieces[24] = blackARook;
            blackARook.сoordinateX = 0;
            blackARook.сoordinateY = 0;
            blackARook.color = ConsoleColor.Black;
            blackARook.consoleChar = Tile.BlackRook;
            blackARook.type = "rook";
            blackARook.moved = false;

            Piece blackHRook = new Piece();
            pieces[25] = blackHRook;
            blackHRook.сoordinateX = 7;
            blackHRook.сoordinateY = 0;
            blackHRook.color = ConsoleColor.Black;
            blackHRook.consoleChar = Tile.BlackRook;
            blackHRook.type = "rook";
            blackHRook.moved = false;

            Piece blackBKnight = new Piece();
            pieces[26] = blackBKnight;
            blackBKnight.сoordinateX = 1;
            blackBKnight.сoordinateY = 0;
            blackBKnight.color = ConsoleColor.Black;
            blackBKnight.consoleChar = Tile.BlackKnight;
            blackBKnight.type = "knight";

            Piece blackGKnight = new Piece();
            pieces[27] = blackGKnight;
            blackGKnight.сoordinateX = 6;
            blackGKnight.сoordinateY = 0;
            blackGKnight.color = ConsoleColor.Black;
            blackGKnight.consoleChar = Tile.BlackKnight;
            blackGKnight.type = "knight";

            Piece blackCBishop = new Piece();
            pieces[28] = blackCBishop;
            blackCBishop.сoordinateX = 2;
            blackCBishop.сoordinateY = 0;
            blackCBishop.color = ConsoleColor.Black;
            blackCBishop.consoleChar = Tile.BlackBishop;
            blackCBishop.type = "bishop";

            Piece blackFBishop = new Piece();
            pieces[29] = blackFBishop;
            blackFBishop.сoordinateX = 5;
            blackFBishop.сoordinateY = 0;
            blackFBishop.color = ConsoleColor.Black;
            blackFBishop.consoleChar = Tile.BlackBishop;
            blackFBishop.type = "bishop";

            Piece blackQueen = new Piece();
            pieces[30] = blackQueen;
            blackQueen.сoordinateX = 3;
            blackQueen.сoordinateY = 0;
            blackQueen.color = ConsoleColor.Black;
            blackQueen.consoleChar = Tile.BlackQueen;
            blackQueen.type = "queen";

            Piece blackKing = new Piece();
            pieces[31] = blackKing;
            blackKing.сoordinateX = 4;
            blackKing.сoordinateY = 0;
            blackKing.color = ConsoleColor.Black;
            blackKing.consoleChar = Tile.BlackKing;
            blackKing.type = "king";
            blackKing.moved = false;

            #endregion

            return pieces;
        }
        
        void PiecesStartPosition(string[,] board, Piece[] pieces)
        {
            for (int i = 0; i < pieces.Length; i++)
            {
                Piece.Display(board, pieces[i]);
            }
        }
    }
}