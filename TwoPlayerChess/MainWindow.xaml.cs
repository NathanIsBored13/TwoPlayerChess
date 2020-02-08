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
			MWindow.Style = (Style)FindResource("Grayscale");
			Icons.LoadPool("Simple_Pieces");
			board = new Board(UniformGrid, GridButtonPressed, cellSize);
		}

		private void GridButtonPressed(object sender, RoutedEventArgs e)
		{
			Cell button = (Cell)sender;
			Console.WriteLine($"{button.Position[0]}, {button.Position[1]}");
		}

		public void CellClicked(int x, int y)
		{

		}
	}
}
