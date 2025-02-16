namespace Belly.Algorithm.LeetCode;

public class LeetCode881
{
    public int NumRescueBoats(int[] people, int limit)
    {
        if (people == null || people.Length <= 0)
        {
            return 0;
        }

        Array.Sort(people);
        int answer = 0, sum, left = 0, right = people.Length - 1;
        while (left <= right)
        {
            sum = left == right ? people[left] : people[left] + people[right];
            if (sum <= limit)
            {
                left++;
            }
            right--;
            answer++;
        }

        return answer;
    }
}
