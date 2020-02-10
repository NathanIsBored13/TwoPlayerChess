using System.Collections.Generic;
using System.Windows.Media;

namespace TwoPlayerChess
{
    enum Pieces
    {
        King,
        Queen,
        Rook,
        Bishop,
        Knight,
        Pawn
    };
    abstract class Piece
    {
        public Colour colour { get; }
        public Pieces type { get; }
        public ImageSource image { get; set; }
        public Cell cell { get; set; }
        public Piece(Colour colour, Pieces type)
        {
            this.colour = colour;
            this.type = type;
        }

        public abstract Cell[] GetMoves(Board board);

        public void SetCell(Cell cell)
        {
            this.cell = cell;
        }

        public List<Cell> GetHorisontals(Board board)
        {
            List<Cell> ret = new List<Cell>();
            int[] pointer = new int[] { cell.Position.x, cell.Position.y };
            int[] dir = new int[] { 1, 0 };
            int count = 0;
            do
            {
                pointer[0] += dir[0];
                pointer[1] += dir[1];
                if (pointer[0] > 7 || pointer[0] < 0 || pointer[1] > 7 || pointer[1] < 0)
                {
                    pointer = new int[] { cell.Position.x, cell.Position.y };
                    count++;
                    if (count == 1) dir = new int[] { 0, 1 };
                    else if (count == 2) dir = new int[] { -1, 0 };
                    else if (count == 3) dir = new int[] { 0, -1 };
                }
                else
                {
                    ret.Add(board.grid[pointer[0], pointer[1]]);
                    if (board.grid[pointer[0], pointer[1]]?.piece != null)
                    {
                        pointer = new int[] { cell.Position.x, cell.Position.y };
                        count++;
                        if (count == 1) dir = new int[] { 0, 1 };
                        else if (count == 2) dir = new int[] { -1, 0 };
                        else if (count == 3) dir = new int[] { 0, -1 };
                    }
                }
            } while (count < 4);
            return ret;
        }

        public List<Cell> GetDiagonals(Board board)
        {
            List<Cell> ret = new List<Cell>();
            int[] pointer = new int[] { cell.Position.x, cell.Position.y };
            int[] dir = new int[] { 1, 1 };
            int count = 0;
            do
            {
                pointer[0] += dir[0];
                pointer[1] += dir[1];
                if (pointer[0] > 7 || pointer[0] < 0 || pointer[1] > 7 || pointer[1] < 0)
                {
                    pointer = new int[] { cell.Position.x, cell.Position.y };
                    count++;
                    if (count == 1) dir = new int[] { -1, 1 };
                    else if (count == 2) dir = new int[] { -1, -1 };
                    else if (count == 3) dir = new int[] { 1, -1 };
                }
                else
                {
                    ret.Add(board.grid[pointer[0], pointer[1]]);
                    if (board.grid[pointer[0], pointer[1]]?.piece != null)
                    {
                        pointer = new int[] { cell.Position.x, cell.Position.y };
                        count++;
                        if (count == 1) dir = new int[] { -1, 1 };
                        else if (count == 2) dir = new int[] { -1, -1 };
                        else if (count == 3) dir = new int[] { 1, -1 };
                    }
                }
            } while (count < 4);
            return ret;
        }

        public Cell[] GetKingsMoves(Board board)
        {
            List<Cell> ret = new List<Cell>();
            if (cell.Position.x != 0)
            {
                ret.Add(board.grid[cell.Position.x - 1, cell.Position.y]);
                if (cell.Position.y != 0) ret.Add(board.grid[cell.Position.x - 1, cell.Position.y - 1]);
                if (cell.Position.y != 7) ret.Add(board.grid[cell.Position.x - 1, cell.Position.y + 1]);
            }
            if (cell.Position.x != 7)
            {
                ret.Add(board.grid[cell.Position.x + 1, cell.Position.y]);
                if (cell.Position.y != 0) ret.Add(board.grid[cell.Position.x + 1, cell.Position.y - 1]);
                if (cell.Position.y != 7) ret.Add(board.grid[cell.Position.x + 1, cell.Position.y + 1]);
            }
            if (cell.Position.y != 0) ret.Add(board.grid[cell.Position.x, cell.Position.y - 1]);
            if (cell.Position.y != 7) ret.Add(board.grid[cell.Position.x, cell.Position.y + 1]);
            return ret.ToArray();
        }
    }
}
