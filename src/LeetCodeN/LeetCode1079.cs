namespace Algorithm.LeetCode;

public class LeetCode1079
{
    public int NumTilePossibilities(string tiles)
    {
        if (string.IsNullOrEmpty(tiles))
        {
            return 0;
        }

        int[] count = new int[26];
        foreach (var ch in tiles)
        {
            count[ch - 'A']++;
        }
        return DFS(count);
    }

    private int DFS(int[] count)
    {
        int answer = 0;
        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] > 0)
            {
                answer++;
                count[i]--;
                answer += this.DFS(count);
                count[i]++;
            }
        }
        return answer;
    }
}