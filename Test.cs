using EducationalPractical.Practical2_2;
using Task1 = EducationalPractical.Practical2_1.Task1;
using Task2 = EducationalPractical.Practical2_1.Task2;
using Task3 = EducationalPractical.Practical2_1.Task3;

namespace EducationalPractical;

public class Test
{
    public static void Main() 
    {
        Console.WriteLine("Практическая 2.1");
        Console.WriteLine("1 - задание 1");
        Console.WriteLine("2 - задание 2");
        Console.WriteLine("3 - задание 3");
        Console.WriteLine("Практическая 2.2");
        Console.WriteLine("4 - задание 1");
        Console.WriteLine("5 - задание 2");
        Console.WriteLine("6 - задание 3");
        Console.WriteLine("7 - задание 4");
        Console.WriteLine("8 - задание 5");
        Console.WriteLine("Практическая 2.3");
        Console.WriteLine("9 - задание 1");
        Console.WriteLine("10 - задание 2");
        Console.WriteLine("11 - задание 3");
        Console.WriteLine("Практическая 2.4");
        Console.WriteLine("12 - задание 1");

        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Task1.startProgram();
                break;
            case 2:
                Task2.startProgram();
                break;
            case 3:
                Task3.startProgram();
                break;
            case 4:
                Practical2_2.Task1.startProgram();
                break;
            case 5:
                Practical2_2.Task2.startProgram();
                break;
            case 6:
                Practical2_2.Task3.startProgram();
                break;
            case 7:
                Task4.startProgram();
                break;
            case 8:
                Task5.startProgram();
                break;
            case 9:
                Practical2_3.Task1.startProgram();
                break;
            case 10:
                Practical2_3.Task2.startProgram();
                break;
            case 11:
                Practical2_3.Task3.startProgram();
                break;
            case 12:
                Practical2_4.Task1.startProgram();
                break;
            
        }

    }
}