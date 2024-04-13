namespace EducationalPractical.Practical2_1;

public class Task3
{
    public static void startProgram()
    {
        int[] nums = { 5, 1, 34, 2, 2, 1, 0, -3, 23};
        Array.Sort(nums);

        int temp = nums[0];

        for (int i = 0; i < nums.Length - 1; i++) 
        {
            if (temp == nums[i + 1]) 
            {
                Console.WriteLine(true);
                return;
            }
            else 
            {
                temp = nums[i + 1];
            }
        }
        Console.WriteLine(false);
    }
}