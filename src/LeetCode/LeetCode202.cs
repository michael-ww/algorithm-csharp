namespace Belly.Algorithm.LeetCode;

public class LeetCode202
{
    public bool IsHappy(int n)
    {
        int fast = this.GetNext(n);
        int slow = n;
        while (fast != slow)
        {
            fast = this.GetNext(this.GetNext(fast));
            slow = this.GetNext(slow);
        }
        return fast == 1;
    }

    private int GetNext(int n)
    {
        int answer = 0;
        while (n > 0)
        {
            int num = n % 10;
            answer += num * num;
            n /= 10;
        }
        return answer;
    }
}
