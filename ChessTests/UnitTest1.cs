using ChessLibrary;

namespace ChessTests;

public class UnitTest1
{
    [Fact]
    public void Field_can_be_created()
    {
        var Field = new ChessField();
        Assert.NotNull(Field);
    }
    [Fact]
    public void King_can_be_placed()
    {
        var Field = new ChessField();
        var King = new Figure(true, FigureType.King);
        string expected = "K";
        Field.PlaceFigure(King,1,1);
        //Assert.Equal(Field.Get_symbole_on_Field(1,1),expected);
    }

        [Fact]
    public void King_can_be_moved()
    {
        var Field = new ChessField();
        var King = new Figure(true, FigureType.King);
        string expected = "K";
        Field.PlaceFigure(King,0,0);
        Field.MoveFigure('A',0,'B',0);
        //Assert.Equal(Field.Get_symbole_on_Field(0,1),expected);
    }
}