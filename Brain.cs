using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGenius1
{
    internal class Brain
    {
        public static List<Move> LegalMovesFor(Board board)
        {
            var moves = new List<Move>();

            for (var i = 0; i < 64; i++)
            {
                if ((board.Square[i] & (board.WhitesTurn ? Piece.White : Piece.Black)) != 0)
                {
                    //int test = board.Square[i] & Piece.Pawn;

                    if ((board.Square[i] & Piece.Mask) == Piece.Pawn)
                    {
                        moves.Add(new Move(i, i - 8)); //can move forward 1
                        moves.Add(new Move(i, i - 16)); //can move forward 2
                        //take on left diagonal
                        //take on right diagonal
                    }

                    if ((board.Square[i] & Piece.Mask) == Piece.Knight)
                    {
                        int j;
                        j = i - 17; //2 up, 1 left
                        if (Board.File(i) > 0 && board.CheckMove(j) > -1)
                            moves.Add(new Move(i, j));
                        j = i - 15; //2 up, 1 right
                        if (Board.File(i) < 7 && board.CheckMove(j) > -1)
                            moves.Add(new Move(i, j));
                        j = i - 10; //1 up, 2 left
                        if (Board.File(i) > 1 && board.CheckMove(j) > -1)
                            moves.Add(new Move(i, j));
                        j = i - 6; //1 up, 2 right
                        if (Board.File(i) < 6 && board.CheckMove(j) > -1)
                            moves.Add(new Move(i, j));
                        j = i + 6; //1 down, 2 left
                        if (Board.File(i) > 1 && board.CheckMove(j) > -1)
                            moves.Add(new Move(i, j));
                        j = i + 10; //1 down, 2 right
                        if (Board.File(i) < 6 && board.CheckMove(j) > -1)
                            moves.Add(new Move(i, j));
                        j = i + 15; //2 down, 1 left
                        if (Board.File(i) > 0 && board.CheckMove(j) > -1)
                            moves.Add(new Move(i, j));
                        j = i + 17; ////2 down, 1 right
                        if (Board.File(i) < 7 && board.CheckMove(j) > -1)
                            moves.Add(new Move(i, j));
                    }

                    if ((board.Square[i] & Piece.Mask) == Piece.Bishop)
                    {
                        for (int j = i-9; j >= 0; j=j-9)
                        {
                            if (board.CheckMove(j) > -1)
                                moves.Add(new Move(i, j)); //up to the left
                            else break;
                            if (Board.Rank(i) == 0 || Board.File(i) == 0)
                                break; //stop working to the left once you've reached the end of the board
                        }
                        for (int j = i-7; j >= 0; j=j-7)
                        {
                            if (board.CheckMove(j) > -1)
                                moves.Add(new Move(i, j)); //up to the right
                            else break;
                            if (Board.Rank(i) == 0 || Board.File(i) == 7)
                                break; //stop working to the left once you've reached the end of the board
                        }
                        for (int j = i+7; j < 64; j=j+7)
                        {
                            if (board.CheckMove(j) > -1)
                                moves.Add(new Move(i, j)); //down to the left
                            else break;
                            if (Board.Rank(i) == 7 || Board.File(i) == 0)
                                break; //stop working to the left once you've reached the end of the board
                        }
                        for (int j = i + 9; j < 64; j = j + 9)
                        {
                            if (board.CheckMove(j) > -1)
                                moves.Add(new Move(i, j)); //down to the right
                            else break;
                            if (Board.Rank(i) == 7 || Board.File(i) == 7)
                                break; //stop working to the left once you've reached the end of the board
                        }
                    }

                    if ((board.Square[i] & Piece.Mask) == Piece.Rook)
                    {
                        for(int j = i - 1; j >= 0; j--)
                        {
                            if (board.CheckMove(j) > -1)
                                moves.Add(new Move(i, j)); //left
                            else break;
                        }
                        for (int j = i + 1; j < 64; j++)
                        {
                            if (board.CheckMove(j) > -1)
                                moves.Add(new Move(i, j)); //right
                            else break;
                        }
                        for (int j = i + 1; j >= 0; j=j-8)
                        {
                            if (board.CheckMove(j) > -1)
                                moves.Add(new Move(i, j)); //up
                            else break;
                        }
                        for (int j = i - 8; j < 64; j=j+8)
                        {
                            if (board.CheckMove(j) > -1)
                                moves.Add(new Move(i, j)); //down
                            else break;
                        }
                    }

                    if ((board.Square[i] & Piece.Mask) == Piece.Queen)
                    {
                        for (int j = i - 9; j >= 0; j = j - 9)
                        {
                            if (board.CheckMove(j) > -1)
                                moves.Add(new Move(i, j)); //up to the left
                            else break;
                        }
                        for (int j = i - 7; j >= 0; j = j - 7)
                        {
                            if (board.CheckMove(j) > -1)
                                moves.Add(new Move(i, j)); //up to the right
                            else break;
                        }
                        for (int j = i + 7; j < 64; j = j + 7)
                        {
                            if (board.CheckMove(j) > -1)
                                moves.Add(new Move(i, j)); //down to the left
                            else break;
                        }
                        for (int j = i + 9; j < 64; j = j + 9)
                        {
                            if (board.CheckMove(j) > -1)
                                moves.Add(new Move(i, j)); //down to the right
                            else break;
                        }
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if (board.CheckMove(j) > -1)
                                moves.Add(new Move(i, j)); //left
                            else break;
                        }
                        for (int j = i + 1; j < 64; j++)
                        {
                            if (board.CheckMove(j) > -1)
                                moves.Add(new Move(i, j)); //right
                            else break;
                        }
                        for (int j = i + 1; j >= 0; j = j - 8)
                        {
                            if (board.CheckMove(j) > -1)
                                moves.Add(new Move(i, j)); //up
                            else break;
                        }
                        for (int j = i - 8; j < 64; j = j + 8)
                        {
                            if (board.CheckMove(j) > -1)
                                moves.Add(new Move(i, j)); //down
                            else break;
                        }
                    }

                    if ((board.Square[i] & Piece.Mask) == Piece.King)
                    {
                        int j;
                        j = i - 9; //up to the left
                        if (board.CheckMove(j) > -1)
                            moves.Add(new Move(i, j)); 
                        j = i - 8; //up
                        if (board.CheckMove(j) > -1)
                            moves.Add(new Move(i, j));
                        j = i - 7; //up to the right
                        if (board.CheckMove(j) > -1)
                            moves.Add(new Move(i, j));
                        j = i - 1; //left
                        if (board.CheckMove(j) > -1)
                            moves.Add(new Move(i, j));
                        j = i + 1; //right
                        if (board.CheckMove(j) > -1)
                            moves.Add(new Move(i, j));
                        j = i + 7; //down to the left
                        if (board.CheckMove(j) > -1)
                            moves.Add(new Move(i, j));
                        j = i + 8; //down
                        if (board.CheckMove(j) > -1)
                            moves.Add(new Move(i, j));
                        j = i + 9; //down to the right
                        if (board.CheckMove(j) > -1)
                            moves.Add(new Move(i, j));
                    }
                }
            }
            //foreach (byte square in board.Square.Where(x => (x & (board.WhitesTurn ? Piece.White : Piece.Black)) != 0))
            //{
            //    string debug = "here";
            //}
            return moves;
        }
    }
}
