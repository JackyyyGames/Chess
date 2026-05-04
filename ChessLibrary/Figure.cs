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

        public bool hasmoved { get; set; }


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
        public bool CanMove(int fromx, int fromy, int tox, int toy, Figure?[,] field)
        {
            switch (type)
            {
                case FigureType.King:
                    return CanMoveKing(fromx, fromy, tox, toy);
                case FigureType.Pawn:
                    return CanMovePawn(fromx, fromy, tox, toy, field);
                case FigureType.Rook:
                    return CanMoveRook(fromx, fromy, tox, toy, field);
                case FigureType.Bishop:
                    return CanMoveBishop(fromx, fromy, tox, toy, field);
                case FigureType.Knight:
                    return CanMoveKnight(fromx, fromy, tox, toy);
                case FigureType.Queen:
                    return CanMoveQueen(fromx, fromy, tox, toy, field);

                default:
                    return true;
            }
        }
        public bool CanMoveKing(int fromx, int fromy, int tox, int toy)
        {
            if (Math.Abs(tox - fromx) <= 1 && Math.Abs(toy - fromy) <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CanMovePawn(int fromx, int fromy, int tox, int toy, Figure?[,] field)
        {
            if (Math.Abs(tox - fromx) == 1)
            {
                if (field[toy, tox] != null && field[toy, tox]?.isblack != isblack)
                {
                    return true;
                }
                return false;
            }

            if (field[toy, tox] != null)
            {
                return false;
            }
            if (this.hasmoved == true)
            {
                if (this.isblack == true)
                {
                    return toy - fromy <= 1 && fromx == tox;
                }
                else
                {
                    return fromy - toy <= 1 && fromx == tox;
                }
            }
            else
            {
                if (this.isblack == true)
                {
                    return toy - fromy <= 2 && fromx == tox;
                }
                else
                {
                    return fromy - toy <= 2 && fromx == tox;
                }
            }
        }
        public bool CanMoveRook(int fromx, int fromy, int tox, int toy, Figure?[,] field)
        {
            if (fromx != tox && fromy != toy)
            {
                return false;
            }
            if (fromx != tox)
            {
                int step = fromx < tox ? 1 : -1;
                for (int x = fromx + step; x != tox; x += step)
                {
                    if (field[fromy, x] != null)
                    {
                        return false;
                    }
                }
            }
            else
            {
                int step = fromy < toy ? 1 : -1;
                for (int y = fromy + step; y != toy; y += step)
                {
                    if (field[y, fromx] != null) return false;
                }
            }

            return true;
        }
        public bool CanMoveBishop(int fromx, int fromy, int tox, int toy, Figure?[,] field)
        {
            if (Math.Abs(tox - fromx) != Math.Abs(toy - fromy))
            {
                return false;
            }

            int stepX = fromx < tox ? 1 : -1;
            int stepY = fromy < toy ? 1 : -1;

            int xcurrent = fromx + stepX;
            int ycurrent = fromy + stepY;

            while (xcurrent != tox && ycurrent != toy)
            {
                if (field[ycurrent, xcurrent] != null)
                {
                    return false;
                }
                xcurrent += stepX;
                ycurrent += stepY;
            }
            return true;
        }
        public bool CanMoveKnight(int fromx, int fromy, int tox, int toy)
        {
            int directionX = Math.Abs(tox - fromx);
            int directionY = Math.Abs(toy - fromy);
            if (directionX == 2 && directionY == 1 || directionX == 1 && directionY == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CanMoveQueen(int fromx, int fromy, int tox, int toy, Figure?[,] field)
        {
            if (CanMoveRook(fromx, fromy, tox, toy, field) || CanMoveBishop(fromx, fromy, tox, toy, field))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
