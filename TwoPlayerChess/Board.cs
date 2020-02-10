using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace TwoPlayerChess
{
	class Board
	{
		public Cell[,] grid;
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
			this.grid[4, 0].SetPiece(new King(Colour.black));
			this.grid[3, 7].SetPiece(new Queen(Colour.white));
			this.grid[4, 7].SetPiece(new King(Colour.white));
		}

		public void HighlightAllMoves(Colour colour)
		{
			List<Cell> cells = new List<Cell>();
			foreach (Cell cell in grid)
			{
				if (cell.piece?.colour == colour)
				{
					if (cell.piece.type == Pieces.King) cells.AddRange(cell.piece.GetKingsMoves(this, cell));
					else if (cell.piece.type == Pieces.Pawn)
					{
						foreach (Cell toAdd in cell.piece.GetMoves(this, cell))
						{
							if (toAdd.Position.x != cell.Position.x) cells.Add(toAdd);
						}
					}
					else cells.AddRange(cell.piece.GetMoves(this, cell));
				}
			}
			foreach (Cell cell in cells) cell.Highlight = 5;
		}

		public bool CheckLoss(Colour colour)
		{
			bool ret = false;
			HighlightAllMoves((Colour)((((int)colour) + 1) % 2));
			foreach (Cell cell in grid)
			{
				if (cell.piece?.type == Pieces.King && cell.piece?.colour == colour)
				{
					if (cell.piece.GetMoves(this, cell).Length == 0 && cell.Highlight == 4)
					{
						ret = true;
					}
					else ret = false;
				}
			}
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
