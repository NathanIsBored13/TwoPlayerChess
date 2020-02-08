using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPlayerChess
{
    enum Colour
    {
        black,
        white
    }
    class Player
    {
        private Cell buffered;
        public Colour colour { get; }
        public Player(Colour colour)
        {
            this.colour = colour;
        }

        public bool Move(Board board, Cell pressed)
        {
            bool ret = false;
            if (pressed.Highlight > 0)
            {
                pressed.SetPiece(buffered.piece);
                buffered.SetPiece(null);
                board.DeselectAll();
                ret = true;
            }
            else if(pressed.piece != null)
            {
                board.DeselectAll();
                buffered = pressed;
                foreach (Cell cell in pressed.piece.GetMoves(board)) cell.Highlight = cell.piece == null ? 1 : 2;
            }
            else
            {
                board.DeselectAll();
            }
            return ret;
        }
    }
}
