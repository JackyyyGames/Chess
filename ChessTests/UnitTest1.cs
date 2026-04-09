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
        var King = new KingFigure(true);
        Field.PlaceKing(King,1,1);
        Assert.Equal(Field.Get_symbole_on_Field(1,1),"K");
    }
}