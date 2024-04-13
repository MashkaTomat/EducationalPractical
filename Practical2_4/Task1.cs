namespace EducationalPractical.Practical2_4;

public class Task1
{
    static readonly Dictionary<char, int> romanConvert = new Dictionary<char, int> 
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public static void startProgram() 
    {
        string romanNum = (Console.ReadLine());

        int result = 0;
        for (int i = 0; i < romanNum.Length; i++) 
        {
            if (i < romanNum.Length - 1 && romanConvert[romanNum[i]] < romanConvert[romanNum[i + 1]]) 
            {
                result -= romanConvert[romanNum[i]];
            }
            else
            {
                result += romanConvert[romanNum[i]];
            }
        }
        Console.WriteLine(result);
    }
}