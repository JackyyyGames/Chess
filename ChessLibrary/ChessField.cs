using ChessLibrary;
namespace ChessLibrary
{
    public class ChessField
    {
        private string[,] Field = new string[8,8];
        
        
        /// <summary>
        /// A ToString that prints out the Chess-Board
        /// </summary>
        /// <returns>returns the string that is the board</returns>
        /// 

        public override string ToString()
        {
            var King = new KingFigure(true);
            Field[1,1] = King.symbole;
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

