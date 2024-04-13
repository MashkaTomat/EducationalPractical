namespace EducationalPractical.Practical2_2;
public class Train 
{
    public string destination { get; set; }
    public int number { get; set; }
    public TimeOnly departure { get; set; }
}
public class Task2
{ 
    public static void startProgram()
    { 
        List<Train> train = new List<Train>();

        train.Add(new Train()
        {
            number = 15,
            destination = "Tokio",
            departure = TimeOnly.Parse("00:00")
        });
        train.Add(new Train() 
        {
            number = 130,
            destination = "Omsk",
            departure = TimeOnly.Parse("12:00")
        });
        train.Add(new Train() 
        {
            number = 400,
            destination = "USA",
            departure = TimeOnly.Parse("10:15")
        });
        train.Add(new Train() 
        { 
            number = 5,
            destination = "Moscow",
            departure = TimeOnly.Parse("10:50")
        });

        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < train.Count; i++)
        {
            if (num == train[i].number)
            {
                Console.WriteLine($"Номер: {train[i].number}");
                Console.WriteLine($"Место: {train[i].destination}");
                Console.WriteLine($"Время: {train[i].departure}");
                break;
            } 
        }
    }
}