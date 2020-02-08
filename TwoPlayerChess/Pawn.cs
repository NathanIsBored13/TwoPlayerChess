using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPlayerChess
{
    class Pawn : Piece
    {
        public Pawn(Colour colour) : base(colour)
        {
            image = colour == Colour.white ? Icons.imagePool.WPawn : Icons.imagePool.BPawn;
        }

        public override Cell[] GetMoves(Board board)
        {
            return new Cell[] { board.grid[3, 3], board.grid[4, 4] };
        }
    }
}
