using System.Collections.Generic;

namespace TwoPlayerChess
{
    class Knight : Piece
    {
        public Knight(Colour colour) : base(colour)
        {
            image = colour == Colour.white ? Icons.imagePool.WKnight : Icons.imagePool.BKnight;
        }

        public override Cell[] GetMoves(Board board, Cell cell)
        {
            List<Cell> ret = new List<Cell>();
            bool[] check = new bool[8] { true, true, true, true, true, true, true, true };
            if (cell.Position.y == 7)
            {
                check[0] = false;
                check[1] = false;
                check[6] = false;
                check[7] = false;
            }
            else if (cell.Position.y == 6)
            {
                check[1] = false;
                check[6] = false;
            }
            if (cell.Position.x == 7)
            {
                check[0] = false;
                check[1] = false;
                check[2] = false;
                check[3] = false;
            }
            else if (cell.Position.x == 6)
            {
                check[1] = false;
                check[2] = false;
            }
            if (cell.Position.y == 0)
            {
                check[2] = false;
                check[3] = false;
                check[4] = false;
                check[5] = false;
            }
            else if (cell.Position.y == 1)
            {
                check[3] = false;
                check[4] = false;
            }
            if (cell.Position.x == 0)
            {
                check[4] = false;
                check[5] = false;
                check[6] = false;
                check[7] = false;
            }
            else if (cell.Position.x == 1)
            {
                check[5] = false;
                check[6] = false;
            }
            if (check[0]) ret.Add(board.grid[cell.Position.x + 1, cell.Position.y + 2]);
            if (check[1]) ret.Add(board.grid[cell.Position.x + 2, cell.Position.y + 1]);
            if (check[2]) ret.Add(board.grid[cell.Position.x + 2, cell.Position.y - 1]);
            if (check[3]) ret.Add(board.grid[cell.Position.x + 1, cell.Position.y - 2]);
            if (check[4]) ret.Add(board.grid[cell.Position.x - 1, cell.Position.y - 2]);
            if (check[5]) ret.Add(board.grid[cell.Position.x - 2, cell.Position.y - 1]);
            if (check[6]) ret.Add(board.grid[cell.Position.x - 2, cell.Position.y + 1]);
            if (check[7]) ret.Add(board.grid[cell.Position.x - 1, cell.Position.y + 2]);
            return ret.ToArray();
        }
    }
}
