//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ChessGenius1
{
    public class Board
    {
        public const string startFEN = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
        public int[] Square;
        public bool WhitesTurn = true; //of course, false means it's black's turn

        public Board()
        {
            Square = new int[64];
        }

        public void Init()
        {
            //set up the pieces
            LoadPositionFromFen(startFEN);
        }

        public void LoadPositionFromFen(string fen)
        {
            var pieceTypeFromSymbol = new Dictionary<char, int>()
            {
                ['k'] = Piece.King,
                ['p'] = Piece.Pawn,
                ['n'] = Piece.Knight,
                ['b'] = Piece.Bishop,
                ['r'] = Piece.Rook,
                ['q'] = Piece.Queen
            };

            string fenBoard = fen.Split(' ')[0];
            int file = 0, rank = 0;

            foreach(char symbol in fenBoard)
            {
                if (symbol == '/')
                {
                    file = 0;
                    rank++; //counts up instead of down because I used 0, 0 in the upper left and he used lower left
                } else
                {
                    if (char.IsDigit(symbol))
                    {
                        file += (int)char.GetNumericValue(symbol);
                    } else
                    {
                        int pieceColor = (char.IsUpper (symbol)) ? Piece.White : Piece.Black;
                        int pieceType = pieceTypeFromSymbol[char.ToLower(symbol)];
                        Square[rank * 8 + file] = (byte)(pieceType | pieceColor);
                        file++;
                    }
                }
            }
        }

        /// <summary>
        /// Returns -1 for invalid, 0 for move to a blank square, 1 for capture
        /// </summary>
        /// <param name="landing"></param>
        /// <returns></returns>
        public int CheckMove(int landing)
        {
            if (landing < 0 || landing > 63)
                return -1;
            if ((Square[landing] & (WhitesTurn ? Piece.Black : Piece.White)) != 0)
                return 1;
            if (Square[landing] == Piece.None)
                return 0;
            return -1; //can't take your own piece
        }

        /// <summary>
        /// Returns 0 (top of the board) through 7 (bottom of the board)
        /// </summary>
        /// <param name="square"></param>
        /// <returns></returns>
        public static int Rank(int square)
        {
            return square / 8;
        }

        /// <summary>
        /// Returns 0 (left of the board) through 7 (right of the board)
        /// </summary>
        /// <param name="square"></param>
        /// <returns></returns>
        public static int File(int square)
        {
            //int debug;
            //if (square == 47)
            //    debug = square % 8;
            return square % 8;
        }
    }
}
