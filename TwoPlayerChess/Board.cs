using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace TwoPlayerChess
{
    class Board
    {
        public Cell[,] grid;
        public King white { get; }
        public King black { get; }
        public Board(UniformGrid grid, RoutedEventHandler handler, int cellSize)
        {
            this.grid = new Cell[8, 8];
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    this.grid[x, y] = new Cell(x, y)
                    {
                        IsTabStop = false,
                        Width = cellSize,
                        Height = cellSize,
                    };
                    this.grid[x, y].Click += handler;
                    grid.Children.Add(this.grid[x, y]);
                }
            }
            for (int x = 0; x < 8; x++)
            {
                this.grid[x, 1].SetPiece(new Pawn(Colour.black));
                this.grid[x, 6].SetPiece(new Pawn(Colour.white));
                if (x == 0 || x == 7)
                {
                    this.grid[x, 0].SetPiece(new Rook(Colour.black));
                    this.grid[x, 7].SetPiece(new Rook(Colour.white));
                }
                else if (x == 1 || x == 6)
                {
                    this.grid[x, 0].SetPiece(new Knight(Colour.black));
                    this.grid[x, 7].SetPiece(new Knight(Colour.white));
                }
                else if (x == 2 || x == 5)
                {
                    this.grid[x, 0].SetPiece(new Bishop(Colour.black));
                    this.grid[x, 7].SetPiece(new Bishop(Colour.white));
                }
            }
            this.grid[3, 0].SetPiece(new Queen(Colour.black));
            black = new King(Colour.black);
            this.grid[4, 0].SetPiece(black);
            this.grid[3, 7].SetPiece(new Queen(Colour.white));
            white = new King(Colour.white);
            this.grid[4, 7].SetPiece(white);
        }

        public void HighlightAllMoves(Colour colour)
        {
            List<Cell> cells = new List<Cell>();
            foreach (Cell cell in grid)
            {
                if (cell.piece?.colour == colour)
                {
                    if (cell.piece.type == Pieces.King) cells.AddRange(cell.piece.GetKingsMoves(this));
                    else if (cell.piece.type == Pieces.Pawn)
                    {
                        foreach (Cell toAdd in cell.piece.GetMoves(this))
                        {
                            if (toAdd.Position.x != cell.Position.x) cells.Add(toAdd);
                        }
                    }
                    else cells.AddRange(cell.piece.GetMoves(this));
                }
            }
            foreach (Cell cell in cells) cell.Highlight = 5;
        }

        public bool CheckLoss(Player player)
        {
            bool ret;
            HighlightAllMoves((Colour)((((int)player.colour) + 1) % 2));
            if (player.king.GetMoves(this).Length == 0 && player.king.cell.Highlight == 4)
            {
                ret = true;
            }
            else ret = false;
            return ret;
        }

        public void DeselectAll()
        {
            foreach (Cell cell in grid)
            {
                if (cell.Highlight != 4) cell.Highlight = 0;
            }
        }
    }
}
