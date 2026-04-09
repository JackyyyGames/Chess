using ChessLibrary;
namespace ChessLibrary
{
    public class ChessField
    {
        private Figure[,] Field = new Figure[8,8];

        public void PlaceFigure(Figure figure,int xcord, int ycord)
        {
            if (Field[ycord,xcord] != null)
            {
                throw new ArgumentException("The place is not empty");
            }
            Field[ycord,xcord] = figure;
        }
        public string Get_symbole_on_Field( int ycord, int xcord)
        {
            return Field[ycord,xcord].symbol;
        }
        //public Figure GetFigure(int ypos, int xpos)
        //{
        //    return Field[ypos,xpos];
        //}
        public void MoveFigure(char xposstart, int yposstart,char xposto, int yposto)
        {
            if (Field[yposstart,CalculateNumberofChar(xposstart)].CanMove(yposstart,CalculateNumberofChar(xposstart)))
            {
                
            }
            Field[yposto,CalculateNumberofChar(xposto)] = Field[yposstart,CalculateNumberofChar(xposstart)];
            Field[yposstart,CalculateNumberofChar(xposstart)] = null;
        }
        public int CalculateNumberofChar(char charakter)
        {
            char c = char.ToLower(charakter);
            return c -'a' ;
        }

        public override string ToString()
        {
            string text = "";
            int rownumber = 1;
            int colorcount = 0;

            text+="  a b c d e f g h" + Environment.NewLine;
            text += "-+-+-+-+-+-+-+-+-+-" + Environment.NewLine;
            
            

            for (int j = 0; j < 8; j++)
            {
                text += $"{rownumber}";
                for (int i = 0; i < 8; i++)
                {
                    if (Field[j,i] == null)
                    {
                      if (colorcount %2 == 0)
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
                        text +="|" + Field[j,i].ToString();
                    }
                    
                    
                    if(i == 7)
                    {
                        text += "|";
                    }
                    colorcount ++;
                }
                colorcount++;
                
                text += $"{rownumber}";
                rownumber ++;


                text += Environment.NewLine;
                

                if (j < 8) 
                {
                    text += "-+-+-+-+-+-+-+-+-+-" + Environment.NewLine;
                    
                }
                
            }
            text+="  a b c d e f g h";

            return text;
        }

    }
}

