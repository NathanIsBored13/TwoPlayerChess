namespace TwoPlayerChess
{
    class Bishop : Piece
    {
        public Bishop(Colour colour) : base(colour, Pieces.Bishop)
        {
            image = colour == Colour.white ? Icons.imagePool.WBishop : Icons.imagePool.BBishop;
        }

        public override Cell[] GetMoves(Board board, Cell cell) => GetDiagonals(board, cell).ToArray();
    }
}
