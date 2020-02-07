using System;
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
		Cell[,] grid;
		public Board(UniformGrid grid, RoutedEventHandler handler, int cellSize)
		{
			this.grid = new Cell[8, 8];
			for (int x = 0; x < 8; x++)
			{
				for (int y = 0; y < 8; y++)
				{
					EButton button = new EButton(x, y)
					{
						Width = cellSize,
						Height = cellSize,
						Margin = new Thickness(1, 1, 1, 1)
					};
					button.Click += handler;
					grid.Children.Add(button);
					this.grid[x, y] = new Cell(button);
				}
			}
		}
	}
}
