using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPlayerChess
{
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
            else
            {
                board.DeselectAll();
                if (pressed.piece?.colour == colour)
                {
                    pressed.Highlight = 1;
                    foreach (Cell cell in pressed.piece.GetMoves(board, pressed))
                    {
                        if (cell.piece?.colour != colour)
                        {
                            cell.Highlight = cell.piece == null ? 2 : 3;
                        }
                    }
                    buffered = pressed;
                }
            }
            return ret;
        }
    }
}
