namespace ChessLibrary
{
    public class KingFigure
    {
        private bool isblack;
        public string symbole{get;} = "k";

        public KingFigure(bool isblack)
        {
            this.isblack = isblack;
            if (isblack == true)
            {
                symbole = symbole.ToUpper();
            }
        }



    }
}
