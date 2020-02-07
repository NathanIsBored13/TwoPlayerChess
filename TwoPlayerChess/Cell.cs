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
    class Cell : Button
    {
        public bool Highlighted
        {
            get { return (bool)GetValue(HighlightedProperty); }
            set { SetValue(HighlightedProperty, value); }
        }
        public static readonly DependencyProperty HighlightedProperty = DependencyProperty.Register("Highlighted", typeof(bool), typeof(Cell));

        public int[] Position { get; }
        public Image image;
        public Piece piece;
        public Cell(int x, int y) : base()
        {
            Position = new int[2] { x, y };
            Highlighted = (y + (x % 2)) % 2 == 0;
            image = new Image
            {
                Stretch = Stretch.UniformToFill
            };
            AddChild(image);
        }

        public void SetPiece(Piece piece)
        {
            this.piece = piece;
            image.Source = piece?.image;
        }
    }
}
