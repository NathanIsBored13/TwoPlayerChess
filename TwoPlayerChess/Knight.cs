using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPlayerChess
{
    class Knight : Piece
    {
        public Knight(Colour colour) : base(colour)
        {
            image = colour == Colour.white ? Icons.imagePool.WKnight : Icons.imagePool.BKnight;
        }

        public override Cell[] GetMoves(Board board, Cell cell)
        {
            throw new NotImplementedException();
        }
    }
}
