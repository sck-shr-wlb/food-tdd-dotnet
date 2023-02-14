namespace RomanNumerals;
public class RomanNumerals
{
    public string convert(int number)
    {
        string result = "";
        while (number != 0)
        {
            result += "I";
            number -= 1;
        }
        return result;
    }
}
