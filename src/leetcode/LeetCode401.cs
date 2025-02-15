namespace Algorithm.LeetCode;

public class LeetCode401
{
    // Time Complexity : O(1)
    // Space Complexity: O(1)
    public IList<string> ReadBinaryWatch1(int turnedOn)
    {
        List<string> answer = new();
        if (turnedOn < 0)
        {
            return answer;
        }

        for (int h = 0; h < 12; h++)
        {
            for (int m = 0; m < 60; m++)
            {
                if (int.PopCount(h) + int.PopCount(m) == turnedOn)
                {
                    string minite = m < 10 ? $"0{m}" : m.ToString();
                    answer.Add($"{h}:{minite}");
                }
            }
        }

        return answer;
    }

    // Time Complexity : O(1)
    // Space Complexity: O(1)
    public IList<string> ReadBinaryWatch2(int turnedOn)
    {
        List<string> answer = new();
        if (turnedOn < 0)
        {
            return answer;
        }

        for (int i = 0; i < 1024; i++)
        {
            int h = i >> 6, m = i & 63;
            if (h < 12 && m < 60 && int.PopCount(i) == turnedOn)
            {
                string minite = m < 10 ? $"0{m}" : m.ToString();
                answer.Add($"{h}:{minite}");
            }
        }

        return answer;
    }
}
