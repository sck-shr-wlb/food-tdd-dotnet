namespace RomanNumerals;
public class RomanNumerals
{
    public string convert(int number)
    {
        string result = "";
        if (number == 4)
        {
            result += "IV";
            number -= 4;
        }
        if (number == 5)
        {
            result += "V";
            number -= 5;
        }
        while (number != 0)
        {
            result += "I";
            number -= 1;
        }
        return result;
    }
}
