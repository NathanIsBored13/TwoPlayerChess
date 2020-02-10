using System.Collections.Generic;

namespace TwoPlayerChess
{
    class Pawn : Piece
    {
        public Pawn(Colour colour) : base(colour, Pieces.Pawn)
        {
            image = colour == Colour.white ? Icons.imagePool.WPawn : Icons.imagePool.BPawn;
        }

        public override Cell[] GetMoves(Board board, Cell cell)
        {
            List<Cell> ret = new List<Cell>();
            if (colour == Colour.white)
            {
                if (cell.Position.y > 0)
                {
                    if (board.grid[cell.Position.x, cell.Position.y - 1].piece == null)
                    {
                        if (cell.Position.y == 6 && board.grid[cell.Position.x, cell.Position.y - 2].piece == null) ret.Add(board.grid[cell.Position.x, cell.Position.y - 2]);
                        ret.Add(board.grid[cell.Position.x, cell.Position.y - 1]);
                    }
                    if (cell.Position.x > 0 && board.grid[cell.Position.x - 1, cell.Position.y - 1].piece != null) ret.Add(board.grid[cell.Position.x - 1, cell.Position.y - 1]);
                    if (cell.Position.x < 7 && board.grid[cell.Position.x + 1, cell.Position.y - 1].piece != null) ret.Add(board.grid[cell.Position.x + 1, cell.Position.y - 1]);
                }
            }
            else
            {
                if (cell.Position.y < 7)
                {
                    if (board.grid[cell.Position.x, cell.Position.y + 1].piece == null)
                    {
                        if (cell.Position.y == 1 && board.grid[cell.Position.x, cell.Position.y + 2].piece == null) ret.Add(board.grid[cell.Position.x, cell.Position.y + 2]);
                        ret.Add(board.grid[cell.Position.x, cell.Position.y + 1]);
                    }
                    if (cell.Position.x > 0 && board.grid[cell.Position.x - 1, cell.Position.y + 1].piece != null) ret.Add(board.grid[cell.Position.x - 1, cell.Position.y + 1]);
                    if (cell.Position.x < 7 && board.grid[cell.Position.x + 1, cell.Position.y + 1].piece != null) ret.Add(board.grid[cell.Position.x + 1, cell.Position.y + 1]);
                }
            }
            return ret.ToArray();
        }
    }
}
