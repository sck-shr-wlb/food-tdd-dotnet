
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

    [Fact]
    public void RomanNumeralsInput4ThenResultShouldBeIV()
    {
        var expectedValue = "IV";
        var romanNumerals = new RomanNumerals.RomanNumerals();

        var output = romanNumerals.convert(4);

        Assert.Equal(expectedValue, output);
    }

    [Fact]
    public void RomanNumeralsInput5ThenResultShouldBeV()
    {
        var expectedValue = "V";
        var romanNumerals = new RomanNumerals.RomanNumerals();

        var output = romanNumerals.convert(5);

        Assert.Equal(expectedValue, output);
    }

    [Fact]
    public void RomanNumeralsInput6ThenResultShouldBeVI()
    {
        var expectedValue = "VI";
        var romanNumerals = new RomanNumerals.RomanNumerals();

        var output = romanNumerals.convert(6);

        Assert.Equal(expectedValue, output);
    }
}