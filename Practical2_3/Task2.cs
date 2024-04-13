namespace EducationalPractical.Practical2_3;

class Worker2 
{
    string name = "Мария";
    string surname = "Глухова";
    int rate = 99999;
    int days = 30;

    public string GetName() 
    {
        return name;
    }

    public string GetSurname() 
    {
        return surname;
    }

    public int GetRate()
    {
        return rate;
    }

    public int GetDays() 
    {
        return days;
    }

    public float GetSalary() 
    {
        return rate * days;
    }
}

public class Task2
{
    public static void startProgram() 
    {
        Worker2 worker = new Worker2();
        Console.WriteLine($"Имя: {worker.GetName()}");
        Console.WriteLine($"Фамилия: {worker.GetSurname()}");
        Console.WriteLine($"Ставка: {worker.GetRate()}");
        Console.WriteLine($"Количество рабочих дней: {worker.GetDays()}");
        Console.WriteLine($"Зарплата: {worker.GetSalary()}");
    }
}