namespace Algorithm.LeetCode;

public class LeetCode191
{
    public int HammingWeight(int n)
    {
        int answer = 0;
        for (int i = 0; i < 32 & n != 0; i++)
        {
            answer += (n >> i) & 1;
        }
        return answer;
    }
}
