using ChessLibrary;
var Field = new ChessField();
var Figure2 = new Figure(false,FigureType.King);
Console.WriteLine(Figure2.symbol);
Field.PlaceFigure(Figure2,0,0);
Console.WriteLine(Field.ToString());
Field.MoveFigure('A',1,'B',2);
Console.WriteLine(Field.ToString());

