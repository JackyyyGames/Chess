using ChessLibrary;

namespace ChessTests;

public class UnitTest1
{
    [Fact]
    public void Field_can_be_created()
    {
        var field = new ChessField();
        Assert.NotNull(field);
    }
    [Fact]
    public void King_can_be_placed()
    {
        var field = new ChessField();
        var king = new Figure(true, FigureType.King);
        string expected = "K";
        field.PlaceFigure(king, 1, 1);
        Assert.Equal(field.GetSymboleOnField(1, 1), expected);
    }

    [Fact]
    public void King_can_be_moved()
    {
        var field = new ChessField();
        var king = new Figure(true, FigureType.King);
        string expected = "K";
        field.PlaceFigure(king, 0, 0);
        field.MoveFigure('A', 0, 'B', 0, true);
        Assert.Equal(field.GetSymboleOnField(0, 1), expected);
    }
    [Fact]
    public void ExceptionTest1()
    {
        string expectedError = "The Figure cant move there";
        try
        {
            var field = new ChessField();
            var king = new Figure(true, FigureType.King);
            field.PlaceFigure(king, 0, 0);
            field.MoveFigure('A', 0, 'B', 0, true);
        }
        catch (ArgumentException e)
        {

            Assert.Equal(e.Message,expectedError);
        }

    }
    [Fact]
    public void ExceptionTest2()
    {
        string expectedError = "The place X:M Y:0 is not on the board!";
        try
        {
            var field = new ChessField();
            var king = new Figure(true, FigureType.King);
            field.PlaceFigure(king, 0, 0);
            field.MoveFigure('A', 0, 'M', 0, true);
        }
        catch (ArgumentException e)
        {

            Assert.Equal(e.Message,expectedError);
        }

    }

     [Fact]
    public void ExceptionTest3()
    {
        string expectedError = "At the place X:B Y:0 is no figure!";
        try
        {
            var field = new ChessField();
            var king = new Figure(true, FigureType.King);
            field.PlaceFigure(king, 0, 0);
            field.MoveFigure('B', 0, 'A', 0, true);
        }
        catch (ArgumentException e)
        {

            Assert.Equal(e.Message,expectedError);
        }

    }
}