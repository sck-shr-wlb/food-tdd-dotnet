namespace RomanNumerals;
public class RomanNumerals
{
    public string convert(int number)
    {
        string result = "";

        while (number != 0)
        {

             if (number >= 5)
            {
                result += "V";
                number -= 5;
            }
            else if (number == 4)
            {
                result += "IV";
                number -= 4;
            }
            else if (number >= 1)
            {
                result += "I";
                number -= 1;
            }

        }
        return result;
    }
}
