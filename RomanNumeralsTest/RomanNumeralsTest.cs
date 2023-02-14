
namespace RomanNumeralsTest;

public class RomanNumeralsTest
{
    [Fact]
    public void RomanNumeralsInput1ThenResultShouldBeI()
    {
        var expectedValue = "I";
        var romanNumerals = new RomanNumerals.RomanNumerals();

        var output = romanNumerals.convert(1);

        Assert.Equal(expectedValue, output);
    }

    [Fact]
    public void RomanNumeralsInput2ThenResultShouldBeII()
    {
        var expectedValue = "II";
        var romanNumerals = new RomanNumerals.RomanNumerals();

        var output = romanNumerals.convert(2);

        Assert.Equal(expectedValue, output);
    }

    [Fact]
    public void RomanNumeralsInput3ThenResultShouldBeIII()
    {
        var expectedValue = "III";
        var romanNumerals = new RomanNumerals.RomanNumerals();

        var output = romanNumerals.convert(3);

        Assert.Equal(expectedValue, output);
    }
}