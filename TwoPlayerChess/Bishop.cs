using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPlayerChess
{
    class Bishop : Piece
    {
        public Bishop(bool colour) : base(colour)
        {
            image = colour ? Icons.imagePool.BBishop : Icons.imagePool.WBishop;
        }

        public override void GetMoves(Board board)
        {

        }
    }
}
