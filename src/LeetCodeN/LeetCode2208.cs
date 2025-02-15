namespace Algorithm.LeetCode;

public class LeetCode2208
{
    public int HalveArray(int[] nums)
    {
        PriorityQueue<double, double> pq = new(Comparer<double>.Create((a, b) => b.CompareTo(a)));
        double sum = 0;
        foreach (var num in nums)
        {
            sum += num;
            pq.Enqueue(num, num);
        }
        sum /= 2;
        int answer = 0;
        for (double minus = 0, current = 0; minus < sum; answer++, minus += current)
        {
            current = pq.Dequeue() / 2;
            pq.Enqueue(current, current);
        }
        return answer;
    }
}
