using System;
using System.Windows;

namespace TwoPlayerChess
{
	enum Colour
	{
		black,
		white
	}
		
	public struct Position
	{
		public int x;
		public int y;
		public Position(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}
	public partial class MainWindow : Window
	{
		readonly int cellSize = 50;
		readonly Board board;
		readonly Player[] players;
		int index;

		public MainWindow()
		{
			InitializeComponent();
			MWindow.Style = (Style)FindResource("Grayscale");
			Icons.LoadPool("Simple_Pieces");
			board = new Board(UniformGrid, Cell_Click, cellSize);
			players = new Player[2];
			players[0] = new Player(Colour.white, board.white);
			players[1] = new Player(Colour.black, board.black);
		}

		private void Cell_Click(object sender, RoutedEventArgs e)
		{
			if (players[index].Move(board, (Cell)sender))
			{
				if (board.CheckLoss(players[(index + 1) % 2]))
				{
					Console.WriteLine($"{players[index].colour} won!");
				}
				index = (index + 1) % 2;
			}
		}
	}
}
