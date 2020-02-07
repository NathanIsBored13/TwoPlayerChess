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
        private bool colour { get; }
        public ImageSource image { get; set; }

        public Piece(bool colour)
        {
            this.colour = colour;
        }

        public abstract void GetMoves(Board board);
    }
}
