namespace EducationalPractical.Practical2_2;

public class Counter 
{
    public static int i { get; set; }

    public static void increaseByOne() 
    {
        i++;
    }

    public static void reduceByOne() 
    {
        i--;
    }
    public static void setDefault() 
    {
        i = 1242;
    }

    public static void setRandomNum()
    {
        Random rand = new Random();
        i = rand.Next(-100, 101);
    }
}

public class Task4
{
    public static void startProgram()
    {
        Console.WriteLine("Счётчик по умолчанию равен: ");
        Counter.setDefault();

        Console.WriteLine("Случайное значение счётчика равно: ");
        Counter.setRandomNum();

        Console.WriteLine("Уменьшение на 1: ");
        Counter.reduceByOne();

        Console.WriteLine("Увеличение на 1: ");
        Counter.increaseByOne();

        Console.WriteLine($"Счётчик равен: {Counter.i}");
    }
}

