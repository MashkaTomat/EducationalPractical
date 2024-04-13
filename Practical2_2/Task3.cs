namespace EducationalPractical.Practical2_2;

public class Numbers
{
    public int num1 { get; set; }
    public int num2 { get; set; }
}

public class Task3
{
    public static void startProgram()
    {
        Numbers nums = new Numbers() 
        {
            num1 = 10,
            num2 = 20
        };

        Console.WriteLine($"Первое число: {nums.num1}");
        Console.WriteLine($"Второе число: {nums.num2}");

        Console.WriteLine("Введите 2 числа:");

        nums = new Numbers() 
        {
            num1 = int.Parse(Console.ReadLine()),
            num2 = int.Parse(Console.ReadLine())
        };

        Console.WriteLine($"Сумма чисел равна {nums.num1 + nums.num2}");
        Console.WriteLine($"Максимальное значение равно {Math.Max(nums.num1, nums.num2)}");
    } 
}