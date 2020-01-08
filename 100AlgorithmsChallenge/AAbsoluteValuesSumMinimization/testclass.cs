using Xunit;

public class testClass
{
    [Fact]
    public void PassingAddTest()
    {

        Assert.Equal(5, Program.Add(2, 3));
        Assert.NotEqual(5, Program.Add(2, 2));

    }
    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(9)]
    public void MyFirstTheory(int myNumber)
    {
        Assert.True(Program.IsOdd(myNumber));
    }
}
