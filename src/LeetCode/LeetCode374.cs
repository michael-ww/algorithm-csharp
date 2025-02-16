namespace Belly.Algorithm.LeetCode;

public class LeetCode374
{

    public int GuessNumber(int n)
    {
        int number = Random.Shared.Next(n + 1);
        int left = 1, right = n, answer = 0;
        while (left <= right)
        {
            int middle = left + ((right - left) >> 1);
            int comparing = number.CompareTo(middle);
            if (comparing > 0)
            {
                left = middle + 1;
            }
            else if (comparing < 0)
            {
                right = middle - 1;
            }
            else
            {
                answer = middle;
                break;
            }
        }
        return answer;
    }
}
