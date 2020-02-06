using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TwoPlayerChess
{
	public partial class MainWindow : Window
	{
		int cellSize = 50;
		Board board;
		public MainWindow()
		{
			InitializeComponent();
			Cell[,] grid = new Cell[8, 8];
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
					button.Click += GridButtonPressed;
					ItemPresenter.Items.Add(button);
					grid[x, y] = new Cell(button);
				}
			}
			board = new Board(grid);
		}

		private void GridButtonPressed(object sender, RoutedEventArgs e)
		{
			EButton button = (EButton)sender;
			Console.WriteLine($"{button.position[0]}, {button.position[1]}");
		}
	}
}
