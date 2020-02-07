using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPlayerChess
{
    class Queen : Piece
    {
        public Queen(bool colour) : base(colour)
        {
            image = colour ? Icons.imagePool.BQueen : Icons.imagePool.WQueen;
        }

        public override void GetMoves(Board board)
        {

        }
    }
}
