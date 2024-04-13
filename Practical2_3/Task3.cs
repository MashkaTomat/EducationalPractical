namespace EducationalPractical.Practical2_3;

public class Calculation 
{
    string calculationLine;

    public void SetCalculationLine() 
    {
        calculationLine = Console.ReadLine();
    }

    public void SetLastSymbolCalculationLine() 
    {
        calculationLine += char.Parse(Console.ReadLine());
    }

    public void DeleteLastSymbol() 
    {
        calculationLine = calculationLine.Remove(calculationLine.Length - 1);;
    }

    public void GetCalculationLine() 
    {
        Console.WriteLine(calculationLine);
    }

    public void GetLastSymbol() 
    {
        Console.WriteLine($"Последний символ строки: {calculationLine[calculationLine.Length - 1]}");
    }
}

public class Task3
{
    public static void startProgram()
    {
        Calculation calculation = new Calculation();

        Console.WriteLine("Введите строку:");
        calculation.SetCalculationLine();

        Console.WriteLine("Введите символ:");
        calculation.SetLastSymbolCalculationLine();

        Console.WriteLine("Изменённая строка:");
        calculation.GetCalculationLine();

        calculation.DeleteLastSymbol();
        Console.WriteLine("Последний символ удалён");

        Console.WriteLine("Изменённая строка:");
        calculation.GetCalculationLine();

        Console.WriteLine("Последний символ:");
        calculation.GetLastSymbol();
    }
}

