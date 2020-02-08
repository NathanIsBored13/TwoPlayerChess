﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

		public void DeselectAll()
		{
			foreach (Cell cell in grid) cell.Highlight = 0;
		}
	}
}
