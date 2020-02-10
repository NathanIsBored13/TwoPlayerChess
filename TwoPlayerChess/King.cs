using System.Collections.Generic;

namespace TwoPlayerChess
{
    class King : Piece
    {
        public King(Colour colour) : base(colour, Pieces.King)
        {
            image = colour == Colour.white ? Icons.imagePool.WKing : Icons.imagePool.BKing;
        }

        public override Cell[] GetMoves(Board board)
        {
            List<Cell> ret = new List<Cell>();
            board.HighlightAllMoves((Colour) ((((int) colour) + 1) % 2));
            if (cell.Highlight == 5)
            {
                cell.Highlight = 4;
                System.Console.WriteLine("check");
            }
            foreach (Cell possible in GetKingsMoves(board)) if (possible.Highlight != 5) ret.Add(possible);
            board.DeselectAll();
            return ret.ToArray();
        }
    }
}
