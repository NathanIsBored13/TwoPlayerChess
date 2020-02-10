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
            if (pressed.Highlight == 2 || pressed.Highlight == 3)
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
                    foreach (Cell cell in pressed.piece.GetMoves(board, pressed))
                    {
                        if (cell.piece == null) cell.Highlight = 2;
                        else if (cell.piece.colour != colour) cell.Highlight = 3;
                    }
                    if (pressed.Highlight != 4) pressed.Highlight = 5;
                    buffered = pressed;
                }
            }
            return ret;
        }
    }
}
