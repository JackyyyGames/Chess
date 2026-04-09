namespace ChessLibrary
{
    public enum FigureType
    {
        King,
        Queen,
        Rook,
        Bishop,
        Knight,
        Pawn
    }
    public class Figure
    {
        private bool isblack;
        private FigureType type;
        public string symbol { get; set; }


        public Figure(bool isblack, FigureType type)
        {
            this.isblack = isblack;
            this.type = type;
            if (isblack == false)
            {
                symbol = GetSymbol(type).ToLower();
            }
            else
            {
                symbol = GetSymbol(type);
            }
        }
        public string GetSymbol(FigureType type)
        {
            switch (type)
            {
                case FigureType.King: return "K";
                case FigureType.Queen: return "Q";
                case FigureType.Rook: return "R";
                case FigureType.Bishop: return "B";
                case FigureType.Knight: return "N";
                case FigureType.Pawn: return "P";
                default: return "?";
            }
        }
        public bool CanMove(int from, int to)
        {
            switch (type)
            {
                case FigureType.King:
                    return CanMoveKing( from, to);

                default:
                    return false;
            }
        }
        public bool CanMoveKing( int from,  int to)
        {
            return true;
        }



    }
}
