using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TwoPlayerChess
{
    abstract class Piece
    {
        public Colour colour { get; }
        public ImageSource image { get; set; }

        public Piece(Colour colour)
        {
            this.colour = colour;
        }

        public abstract Cell[] GetMoves(Board board);
    }
}
