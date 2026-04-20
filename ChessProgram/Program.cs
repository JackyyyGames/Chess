using ChessLibrary;
var field = new ChessField();
var figure2 = new Figure(false, FigureType.Pawn);
var figure3 = new Figure(true, FigureType.Queen);
try
{
    Console.WriteLine(figure2.symbol);
    field.PlaceFigure(figure2, 0, 0);
    //Field.PlaceFigure(Figure3, 1, 0);
    
    
    //Field.Setup();
    Console.WriteLine(field.ToString());
    field.MoveFigure('A', 0, 'A', 1);
    Console.WriteLine(field.ToString());
}
catch (ArgumentException e)
{
    Console.WriteLine($"Error: {e.Message}");
}


