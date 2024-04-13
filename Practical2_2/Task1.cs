namespace EducationalPractical.Practical2_2;

public class Student 
{
    public string surname { get; set; }
    public DateOnly birth { get; set; }
    public int groupNumber { get; set; }
    public int[] academicPerformance { get; set; }
}
public class Task1
{
    public static void startProgram()
    {
        {
            Student studentData = new Student()
            {
                surname = Console.ReadLine(),
                birth = DateOnly.Parse(Console.ReadLine()),
                groupNumber = int.Parse(Console.ReadLine()),
                academicPerformance = [5, 4, 2, 3, 5]
            };
            printStudentData(studentData);
        }
        static void printStudentData(Student studentData) 
        {
            Console.WriteLine(studentData.surname);
            Console.WriteLine(studentData.birth);
            Console.WriteLine(studentData.groupNumber);
            Console.WriteLine("Успеваемость: ");

            for (int i = 0; i < studentData.academicPerformance.Length; i++) 
            {
                Console.Write($"{studentData.academicPerformance[i]}, ");
            }
        }
    }
}