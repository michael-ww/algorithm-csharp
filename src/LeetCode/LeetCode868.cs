namespace Belly.Algorithm.LeetCode;

public class LeetCode868
{
    public int BinaryGap(int n)
    {
        int lastIndex = n, currentIndex = 0, answer = 0;
        while (n != 0)
        {
            if ((n & 1) == 1)
            {
                answer = Math.Max(answer, currentIndex - lastIndex);
                lastIndex = currentIndex;
            }
            currentIndex++;
            n >>= 1;
        }
        return answer;
    }
}