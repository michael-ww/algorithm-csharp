namespace Algorithm.LeetCode;

public class LeetCode475
{
    public int FindRadius(int[] houses, int[] heaters)
    {
        if (houses == null || heaters == null || houses.Length <= 0 || heaters.Length <= 0)
        {
            return 0;
        }

        Array.Sort(houses);
        Array.Sort(heaters);
        int answer = 0;
        for (int i = 0, j = 0; i < houses.Length; i++)
        {
            while (j < heaters.Length - 1 && Math.Abs(houses[i] - heaters[j]) >= Math.Abs(houses[i] - heaters[j + 1]))
            {
                j++;
            }
            answer = Math.Max(answer, Math.Abs(houses[i] - heaters[j]));
        }

        return answer;
    }
}