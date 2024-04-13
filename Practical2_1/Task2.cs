namespace EducationalPractical.Practical2_1;

public class Task2
{
    public static void startProgram()
    {
        int[] candidates = [0, 3, 6, 2, 6, 1, 8, -2, 7];
        int target = 8;

        Array.Sort(candidates);

        List<List<int>> result = new List<List<int>>();

        findComb(candidates, target, new List<int>(), result, 0);

        foreach (List<int> combination in result)
        {
            Console.WriteLine(string.Join(", ", combination));
        }
    }

    static void findComb(int[] candidates, int target, List<int> current, List<List<int>> result, int start) 
    {
        if (target == 0) 
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = start; i < candidates.Length && candidates[i] <= target; i++) 
        {
            if (i > start && candidates[i] == candidates[i - 1])
            {
                continue;
            }
            current.Add(candidates[i]);
            findComb(candidates, target - candidates[i], current, result, i + 1);
            current.RemoveAt(current.Count - 1);
        }
    }
}