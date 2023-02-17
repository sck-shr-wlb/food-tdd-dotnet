namespace RomanNumerals;
public class RomanNumerals
{
    public string convert(int number)
    {
        string result = "";
        string[] romanCharacters = { "XL", "X", "IX", "V", "IV", "I" };
        int[] numberals = { 40, 10, 9, 5, 4, 1 };
        while (number != 0)
        {
            for (int i = 0; i < romanCharacters.Count(); i++)
            {
                if (numberals[i] <= number)
                {
                    result += romanCharacters[i];
                    number -= numberals[i];
                }
                if (number / numberals[i] >= 1)
                {
                    i--;
                }
            }
        }
        return result;
    }
}
