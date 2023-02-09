
namespace RomanNumeralsTest;

public class RomanNumeralsTest
{
    [Fact]
    public void RomanNumeralsInput1ThenResultShouldBeI()
    {
        var expectedValue = "I";
        var romanNumerals = new RomanNumerals.RomanNumerals();
        
        var output = romanNumerals.convert(1);
        
        Assert.Equal(expectedValue,output);
    }
}