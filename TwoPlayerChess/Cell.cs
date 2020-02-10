using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TwoPlayerChess
{
    class Cell : Button
    {
        public bool Checkered
        {
            get { return (bool)GetValue(CheckeredProperty); }
            set { SetValue(CheckeredProperty, value); }
        }
        public static readonly DependencyProperty CheckeredProperty = DependencyProperty.Register("Checkered", typeof(bool), typeof(Cell));
        public int Highlight
        {
            get { return (int)GetValue(HighlighteProperty); }
            set { SetValue(HighlighteProperty, value); }
        }
        public static readonly DependencyProperty HighlighteProperty = DependencyProperty.Register("Highlight", typeof(int), typeof(Cell), new PropertyMetadata(0));

        public Position Position { get; }
        public Image image;
        public Piece piece;
        public Cell(int x, int y) : base()
        {
            Position = new Position(x, y);
            Checkered = (y + (x % 2)) % 2 == 0;
            image = new Image
            {
                Stretch = Stretch.UniformToFill
            };
            AddChild(image);
        }

        public void SetPiece(Piece piece)
        {
            this.piece = piece;
            if (piece != null) piece.SetCell(this);
            image.Source = piece?.image;
        }
    }
}
