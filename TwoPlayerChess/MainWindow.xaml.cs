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
		Player[] players;
		int index;

		public MainWindow()
		{
			InitializeComponent();
			MWindow.Style = (Style)FindResource("Grayscale");
			Icons.LoadPool("Simple_Pieces");
			board = new Board(UniformGrid, Cell_Click, cellSize);
			players = new Player[2];
			players[0] = new Player(Colour.white);
			players[1] = new Player(Colour.black);
		}

		private void Cell_Click(object sender, RoutedEventArgs e)
		{
			if (players[index].Move(board, (Cell) sender))
			{
				index = (index + 1) % 2;
			}
		}
	}
}
