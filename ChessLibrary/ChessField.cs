using ChessLibrary;
namespace ChessLibrary
{
    public class ChessField
    {
        private Figure?[,] Field = new Figure[8, 8];

        public void PlaceFigure(Figure figure, int xcord, int ycord)
        {
            if (Field[ycord, xcord] != null)
            {
                throw new ArgumentException("The place is not empty");
            }
            Field[ycord, xcord] = figure;
        }
        public string? Get_symbole_on_Field(int ycord, int xcord)
        {
            return Field[ycord, xcord]?.symbol;
        }
        public void MoveFigure(char xposstart, int yposstart, char xposto, int yposto)
        {
            Figure? tomove = Field[yposstart, CalculateNumberofChar(xposstart)];
            int xstart = CalculateNumberofChar(xposstart);
            int xto = CalculateNumberofChar(xposto);

            if (tomove != null && tomove.CanMove(xstart, yposstart, xto, yposto))
            {
                if (Field[yposto, xto] != null && Field[yposto, xto]?.isblack == Field[yposstart, yposto]?.isblack)
                {
                    throw new ArgumentException("You want to move at a field that is already yours");
                }
                else
                {
                    Field[yposto, CalculateNumberofChar(xposto)] = Field[yposstart, CalculateNumberofChar(xposstart)];
                    Field[yposstart, CalculateNumberofChar(xposstart)] = null;
                }


            }
            else
            {
                throw new ArgumentException("The Figure cant move there");
            }

        }
        public int CalculateNumberofChar(char charakter)
        {
            char c = char.ToLower(charakter);
            return c - 'a';
        }
        public void Setup()
        {
            SetupBackrow(0, false);
            SetupPawnrow(1, false);
            SetupBackrow(7, true);
            SetupPawnrow(6, true);
        }
        private void SetupBackrow(int row, bool isblack)
        {
            Field[row, 0] = new Figure(isblack, FigureType.Rook);
            Field[row, 7] = new Figure(isblack, FigureType.Rook);

            Field[row, 1] = new Figure(isblack, FigureType.Knight);
            Field[row, 6] = new Figure(isblack, FigureType.Knight);

            Field[row, 2] = new Figure(isblack, FigureType.Bishop);
            Field[row, 5] = new Figure(isblack, FigureType.Bishop);

            Field[row, 3] = new Figure(isblack, FigureType.Queen);
            Field[row, 4] = new Figure(isblack, FigureType.King);
        }
        private void SetupPawnrow(int row, bool isblack)
        {
            for (int i = 0; i < 8; i++)
            {
                Field[row, i] = new Figure(isblack, FigureType.Pawn);
            }
        }

        public override string ToString()
        {
            string text = "";
            int rownumber = 1;
            int colorcount = 0;

            text += "  a b c d e f g h" + Environment.NewLine;
            text += "-+-+-+-+-+-+-+-+-+-" + Environment.NewLine;



            for (int j = 0; j < 8; j++)
            {
                text += $"{rownumber}";
                for (int i = 0; i < 8; i++)
                {
                    if (Field[j, i] == null)
                    {
                        if (colorcount % 2 == 0)
                        {
                            text += "|#";
                        }
                        else
                        {
                            text += "| ";
                        }
                    }
                    else
                    {
                        text += "|" + Field[j, i]?.symbol.ToString();
                    }


                    if (i == 7)
                    {
                        text += "|";
                    }
                    colorcount++;
                }
                colorcount++;

                text += $"{rownumber}";
                rownumber++;


                text += Environment.NewLine;


                if (j < 8)
                {
                    text += "-+-+-+-+-+-+-+-+-+-" + Environment.NewLine;

                }

            }
            text += "  a b c d e f g h";

            return text;
        }

    }
}

