using System;

namespace TwoPlayerChess
{
    class King : Piece
    {
        public King(Colour colour) : base(colour)
        {
            image = colour == Colour.white ? Icons.imagePool.WKing : Icons.imagePool.BKing;
        }

        public override Cell[] GetMoves(Board board, Cell cell)
        {
            throw new NotImplementedException();
        }
    }
}
