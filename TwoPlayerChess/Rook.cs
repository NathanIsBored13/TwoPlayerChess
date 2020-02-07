using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPlayerChess
{
    class Rook : Piece
    {
        public Rook(bool colour) : base(colour)
        {
            image = colour ? Icons.imagePool.BRook : Icons.imagePool.WRook;
        }

        public override void GetMoves(Board board)
        {

        }
    }
}
