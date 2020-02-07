using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPlayerChess
{
    class Knight : Piece
    {
        public Knight(bool colour) : base(colour)
        {
            image = colour ? Icons.imagePool.BKnight : Icons.imagePool.WKnight;
        }

        public override void GetMoves(Board board)
        {

        }
    }
}
