using Xunit;
public class SonarTests
{
   [Fact]
    public void TestShouldReturnTheSameStringAsProvided()
    {
        //Arrange
        var stringer = new Stringer();
        var param = "yo";
        //Act
        var value = stringer.Stringu(param);
        //Assert
        Assert.True(param == value);
    }
}
