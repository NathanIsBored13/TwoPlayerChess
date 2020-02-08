using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPlayerChess
{
    class King : Piece
    {
        public King(Colour colour) : base(colour)
        {
            image = colour == Colour.white ? Icons.imagePool.WKing : Icons.imagePool.BKing;
        }

        public override Cell[] GetMoves(Board board)
        {
            throw new NotImplementedException();
        }
    }
}
