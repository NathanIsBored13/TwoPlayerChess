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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int cellSize = 75;
        Board board;
        public MainWindow()
        {
            InitializeComponent();
            Cell[,] grid = new Cell[9, 9];
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    Button button = new Button
                    {
                        Uid = $"{x.ToString()}:{y.ToString()}",
                        Width = cellSize,
                        Height = cellSize,
                        Margin = new Thickness(1, 1, 1, 1),
                        Background = (x + y) % 2 == 0? Brushes.GhostWhite : Brushes.DimGray
                    };
                    button.Click += GridButtonPressed;
                    grid[x, y] = new Cell(button);
                    UniformGrid.Children.Add(button);
                }
            }
            board = new Board(grid);
        }

        private void GridButtonPressed(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string[] name = button.Uid.Split(':');
            Console.WriteLine($"{name[0]}, {name[1]}");
        }
    }
}
