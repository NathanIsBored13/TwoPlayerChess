namespace TwoPlayerChess
{
    class Rook : Piece
    {
        public Rook(Colour colour) : base(colour)
        {
            image = colour == Colour.white ? Icons.imagePool.WRook : Icons.imagePool.BRook;
        }

        public override Cell[] GetMoves(Board board, Cell cell) => GetHorisontals(board, cell).ToArray();
    }
}
