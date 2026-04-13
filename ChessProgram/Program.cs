using ChessLibrary;
var Field = new ChessField();
var Figure2 = new Figure(false, FigureType.King);
var Figure3 = new Figure(true, FigureType.Queen);
try
{
    Console.WriteLine(Figure2.symbol);
    //Field.PlaceFigure(Figure2, 0, 0);
    //Field.PlaceFigure(Figure3, 1, 0);
    
    
    Field.Setup();
    Console.WriteLine(Field.ToString());
    Field.MoveFigure('A', 1, 'A', 2);
    Console.WriteLine(Field.ToString());
}
catch (ArgumentException e)
{
    Console.WriteLine($"Error: {e.Message}");
}


