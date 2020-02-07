using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPlayerChess
{
    class King : Piece
    {
        public King(bool colour) : base(colour)
        {
            image = colour ? Icons.imagePool.BKing : Icons.imagePool.WKing;
        }

        public override void GetMoves(Board board)
        {

        }
    }
}
