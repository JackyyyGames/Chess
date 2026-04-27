using ChessLibrary;
try
{
    // Alle Hilfsvariablen
    bool isBlack;
    int count = 0;
    char fromX;
    int fromY;
    char toX;
    int toY;

    //Setup vom Feld
    var field = new ChessField();
    field.Setup();
    //Gameplayloop
    do
    {
        if (count % 2 == 0)
        {
            isBlack = true;
        }
        else
        {
            isBlack = false;
        }

        Console.WriteLine(field.ToString());

        if (isBlack == false)
        {
            Console.WriteLine("Weiß ist an der Reihe");
        }
        else
        {
            Console.WriteLine("Schwarz ist an der Reihe");
        }
        Console.WriteLine("Welche Figur: ");
        Console.WriteLine("Spalte eingeben: ");
        if (!char.TryParse(Console.ReadLine(), out fromX))
        {
            throw new ArgumentException("Pleas input a letter between A-H");
        }
        Console.WriteLine("Zeile eingeben: ");

        if (!int.TryParse(Console.ReadLine(), out fromY))
        {
            throw new ArgumentException("Pleas input a number between 1-8");
        }

        Console.WriteLine("Wohin bewegen: ");
        Console.WriteLine("Spalte eingeben: ");
        if (!char.TryParse(Console.ReadLine(), out toX))
        {
            throw new ArgumentException("Pleas input a letter between A-H");
        }
        Console.WriteLine("Zeile eingeben: ");

        if (!int.TryParse(Console.ReadLine(), out toY))
        {
            throw new ArgumentException("Pleas input a number between 1-8");
        }



        field.MoveFigure(fromX, fromY-1, toX, toY-1, isBlack);
        count++;
    }
    while (true);
}
catch (ArgumentException e)
{
    Console.WriteLine($"Error: {e.Message}");
}


