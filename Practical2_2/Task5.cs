namespace EducationalPractical.Practical2_2;

public class Strings 
{
    public string string1;
    public string string2;

    public Strings() 
    {
        string1 = "Ъ";
        string2 = "Ь";
    }

    public Strings(string userString1, string userString2)
    {
        string1 = userString1;
        string2 = userString2;
    }

    ~Strings()
    {
        Console.WriteLine("Объекты уничтожены");
    }
}

public class Task5
{
    public static void startProgram()
    {
        Strings strings = new Strings();

        Console.WriteLine($"Значения по умолчанию равны {strings.string1} и {strings.string2}");

        strings = new Strings(Console.ReadLine(), 
            Console.ReadLine());

        Console.WriteLine($"Введённые значения равны {strings.string1} и {strings.string2}");
    }
}