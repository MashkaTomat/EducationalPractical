namespace EducationalPractical.Practical2_3;

public class Worker 
{
    public string name { get; set; }
    public string surname { get; set; }
    public int rate { get; set; }
    public int days { get; set; }

    public void getSalary() 
    {
        Console.WriteLine($"Зарплата работника: {rate * days}");
    }
}

public class Task1 
{
    public static void startProgram() 
    {
        Worker worker = new Worker() 
        {
            name = "Мария",
            surname = "Глухова",
            rate = 666,
            days = 30
        };

        Console.WriteLine($"Имя: {worker.name}");
        Console.WriteLine($"Фамилия: {worker.surname}");
        Console.WriteLine($"Ставка: {worker.rate}");
        Console.WriteLine($"Количество рабочих дней: {worker.surname}");
        worker.getSalary();
    }
}