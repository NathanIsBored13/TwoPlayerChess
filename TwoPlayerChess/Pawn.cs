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

        public override Cell[] GetMoves(Board board, Cell cell)
        {
            List<Cell> ret = new List<Cell>();
            Console.WriteLine($"{cell.Position[0]}:{cell.Position[1]}");
            if (colour == Colour.white)
            {
                if (cell.Position[1] > 0)
                {
                    if (board.grid[cell.Position[0], cell.Position[1] - 1].piece == null)
                    {
                        if (cell.Position[1] == 6 && board.grid[cell.Position[0], cell.Position[1] - 2].piece == null) ret.Add(board.grid[cell.Position[0], cell.Position[1] - 2]);
                        ret.Add(board.grid[cell.Position[0], cell.Position[1] - 1]);
                    }
                    if (cell.Position[0] > 0 && board.grid[cell.Position[0] - 1, cell.Position[1] - 1].piece != null) ret.Add(board.grid[cell.Position[0] - 1, cell.Position[1] - 1]);
                    if (cell.Position[0] < 7 && board.grid[cell.Position[0] + 1, cell.Position[1] - 1].piece != null) ret.Add(board.grid[cell.Position[0] + 1, cell.Position[1] - 1]);
                }
            }
            else
            {
                if (cell.Position[1] < 7)
                {
                    if (board.grid[cell.Position[0], cell.Position[1] + 1].piece == null)
                    {
                        if (cell.Position[1] == 1 && board.grid[cell.Position[0], cell.Position[1] + 2].piece == null) ret.Add(board.grid[cell.Position[0], cell.Position[1] + 2]);
                        ret.Add(board.grid[cell.Position[0], cell.Position[1] + 1]);
                    }
                    if (cell.Position[0] > 0 && board.grid[cell.Position[0] - 1, cell.Position[1] + 1].piece != null) ret.Add(board.grid[cell.Position[0] - 1, cell.Position[1] + 1]);
                    if (cell.Position[0] < 7 && board.grid[cell.Position[0] + 1, cell.Position[1] + 1].piece != null) ret.Add(board.grid[cell.Position[0] + 1, cell.Position[1] + 1]);
                }
            }
            return ret.ToArray();
        }
    }
}
