using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPlayerChess
{
    class Rook : Piece
    {
        public Rook(Colour colour) : base(colour)
        {
            image = colour == Colour.white ? Icons.imagePool.WRook : Icons.imagePool.BRook;
        }

        public override Cell[] GetMoves(Board board, Cell cell) => GetHorisontals(board, cell).ToArray();
    }
}
