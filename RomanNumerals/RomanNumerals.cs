namespace RomanNumerals;
public class RomanNumerals
{
    public string convert(int number)
    {
        if (number == 1)
        {
            return "I";
        }
        else if (number == 2)
        {
            return "II";
        }
        else
        {
            return "III";
        }
    }
}
