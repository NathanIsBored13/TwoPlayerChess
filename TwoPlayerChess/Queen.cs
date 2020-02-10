using System.Collections.Generic;

namespace TwoPlayerChess
{
    class Queen : Piece
    {
        public Queen(Colour colour) : base(colour, Pieces.Queen)
        {
            image = colour == Colour.white ? Icons.imagePool.WQueen : Icons.imagePool.BQueen;
        }

        public override Cell[] GetMoves(Board board)
        {
            List<Cell> ret = GetHorisontals(board);
            ret.AddRange(GetDiagonals(board));
            return ret.ToArray();
        }
    }
}
