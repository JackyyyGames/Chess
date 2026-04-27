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
        public bool isblack { get; set; }
        private FigureType type;
        public string symbol { get; set; }

        public bool hasmoved{get; set;}


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
        public bool CanMove(int fromx,int fromy, int tox, int toy)
        {
            switch (type)
            {
                case FigureType.King:
                    return CanMoveKing( fromx, fromy, tox, toy);
                case FigureType.Pawn:
                    return CanMovePawn(fromx,fromy,tox,toy);

                default:
                    return true;
            }
        }
        public bool CanMoveKing(int fromx,int fromy, int tox, int toy)
        {
            if (((fromx-tox)+(fromy-toy)) >= -1 &&((fromx-tox)+(fromy-toy)) <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CanMovePawn(int fromx,int fromy, int tox, int toy)
        {
            if (this.hasmoved == true)
            {
                if (this.isblack == true)
                {
                   return toy-fromy <= 1 && fromx == tox; 
                }  
                else
                {
                    return fromy-toy <= 1 && fromx == tox; 
                }
            }
            else
            {
                if (this.isblack == true)
                {
                   return toy-fromy <= 2 && fromx == tox; 
                }  
                else
                {
                    return fromy-toy <= 2 && fromx == tox; 
                }
            }
        }



    }
}
