using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
            //Square[0] = Piece.Black | Piece.Rook;
            //Square[1] = Piece.Black | Piece.Knight;
            //Square[2] = Piece.Black | Piece.Bishop;
            //Square[3] = Piece.Black | Piece.Queen;
            //Square[4] = Piece.Black | Piece.King;
            //Square[5] = Piece.Black | Piece.Bishop;
            //Square[6] = Piece.Black | Piece.Knight;
            //Square[7] = Piece.Black | Piece.Rook;

            //Square[8] = Piece.Black | Piece.Pawn;
            //Square[9] = Piece.Black | Piece.Pawn;
            //Square[10] = Piece.Black | Piece.Pawn;
            //Square[11] = Piece.Black | Piece.Pawn;
            //Square[12] = Piece.Black | Piece.Pawn;
            //Square[13] = Piece.Black | Piece.Pawn;
            //Square[14] = Piece.Black | Piece.Pawn;
            //Square[15] = Piece.Black | Piece.Pawn;

            //Square[48] = Piece.White | Piece.Pawn;
            //Square[49] = Piece.White | Piece.Pawn;
            //Square[50] = Piece.White | Piece.Pawn;
            //Square[51] = Piece.White | Piece.Pawn;
            //Square[52] = Piece.White | Piece.Pawn;
            //Square[53] = Piece.White | Piece.Pawn;
            //Square[54] = Piece.White | Piece.Pawn;
            //Square[55] = Piece.White | Piece.Pawn;

            //Square[56] = Piece.White | Piece.Rook;
            //Square[57] = Piece.White | Piece.Knight;
            //Square[58] = Piece.White | Piece.Bishop;
            //Square[59] = Piece.White | Piece.Queen;
            //Square[60] = Piece.White | Piece.King;
            //Square[61] = Piece.White | Piece.Bishop;
            //Square[62] = Piece.White | Piece.Knight;
            //Square[63] = Piece.White | Piece.Rook;
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
