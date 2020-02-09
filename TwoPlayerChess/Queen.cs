using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPlayerChess
{
    class Queen : Piece
    {
        public Queen(Colour colour) : base(colour)
        {
            image = colour == Colour.white ? Icons.imagePool.WQueen : Icons.imagePool.BQueen;
        }

        public override Cell[] GetMoves(Board board, Cell cell)
        {
            List<Cell> ret = GetHorisontals(board, cell);
            ret.AddRange(GetDiagonals(board, cell));
            return ret.ToArray();
        }
    }
}
