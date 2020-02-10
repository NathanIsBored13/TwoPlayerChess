namespace TwoPlayerChess
{
    class Rook : Piece
    {
        public Rook(Colour colour) : base(colour, Pieces.Rook)
        {
            image = colour == Colour.white ? Icons.imagePool.WRook : Icons.imagePool.BRook;
        }

        public override Cell[] GetMoves(Board board) => GetHorisontals(board).ToArray();
    }
}
