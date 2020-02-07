using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPlayerChess
{
    class Pawn : Piece
    {
        public Pawn(bool colour) : base(colour)
        {
            image = colour ? Icons.imagePool.BPawn : Icons.imagePool.WPawn;
        }

        public override void GetMoves(Board board)
        {

        }
    }
}
