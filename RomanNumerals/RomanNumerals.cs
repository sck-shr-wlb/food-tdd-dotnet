namespace RomanNumerals;
public class RomanNumerals
{
    public string convert(int number)
    {
        string result = "";
        if (number == 4)
        {
            return "IV";
        }
        if (number == 5)
        {
            return "V";
        }
        while (number != 0)
        {
            result += "I";
            number -= 1;
        }
        return result;
    }
}
