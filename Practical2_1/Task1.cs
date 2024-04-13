namespace EducationalPractical.Practical2_1;

public class Task1
{
    public static void startProgram()
    {
        string j = Console.ReadLine();
        string s = Console.ReadLine();
        int count = 0;

        for (int i = 0; i < j.Length; i++)
        {
            for (int k = 0; k < s.Length; k++)
            {
                if (j[i] == s[k])
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
}