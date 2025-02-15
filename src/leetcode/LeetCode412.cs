namespace Algorithm.LeetCode;

public class LeetCode412
{
    public IList<string> FizzBuzz(int n)
    {
        List<string> answer = new();
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                answer.Add("FizzBuzz");
            }
            else if (i % 5 == 0)
            {
                answer.Add("Buzz");
            }
            else if (i % 3 == 0)
            {
                answer.Add("Fizz");
            }
            else
            {
                answer.Add(i.ToString());
            }
        }

        return answer;
    }
}
