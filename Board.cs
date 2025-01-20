//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ChessGenius1
{
    public class Board
    {
        public int[] Square;
        public const string startFEN = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";

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
                        Square[rank * 8 + file] = pieceType | pieceColor;
                        file++;
                    }
                }
            }
        }
    }
}
