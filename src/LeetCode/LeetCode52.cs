namespace Belly.Algorithm.LeetCode;

public class LeetCode52
{
    public int TotalNQueens(int n)
    {
        if (n < 1)
        {
            return 0;
        }

        int limit = (1 << n) - 1;

        return this.Process(limit, 0, 0, 0);
    }

    public int Process(int limit, int column, int left, int right)
    {
        if (column >= limit)
        {
            return 1;
        }

        int ban = column | left | right;
        int candidate = limit & (~ban);
        int place = 0, answer = 0;
        while (candidate != 0)
        {
            place = candidate & (-candidate);
            candidate ^= place;
            answer += this.Process(limit, column | place, (left | place) >> 1, (right | place) << 1);
        }
        return answer;
    }
}
