namespace Algorithm.LeetCode;

public class LeetCode72
{
    public int MinDistance1(string word1, string word2)
    {
        return this.MinDistance(word1, word1.Length, word2, word2.Length, 1, 1, 1);
    }

    private int MinDistance(string word1, int length1, string word2, int length2, int insert, int delete, int replace)
    {
        if (length1 <= 0)
        {
            return length2 * insert;
        }
        if (length2 <= 0)
        {
            return length1 * delete;
        }
        if (word1[length1 - 1] == word2[length2 - 1])
        {
            return this.MinDistance(word1, length1 - 1, word2, length2 - 1, insert, delete, replace);
        }
        else
        {
            return Math.Min(this.MinDistance(word1, length1 - 1, word2, length2 - 1, insert, delete, replace) + replace, Math.Min(this.MinDistance(word1, length1 - 1, word2, length2, insert, delete, replace) + delete, this.MinDistance(word1, length1, word2, length2 - 1, insert, delete, replace) + insert));
        }
    }

    public int MinDistance2(string word1, string word2)
    {
        int[,] dp = new int[word1.Length + 1, word2.Length + 1];
        for (int i = 0; i <= word1.Length; i++)
        {
            for (int j = 0; j <= word2.Length; j++)
            {
                dp[i, j] = -1;
            }
        }
        return this.MinDistance(word1, word1.Length, word2, word2.Length, 1, 1, 1, dp);
    }

    private int MinDistance(string word1, int length1, string word2, int length2, int insert, int delete, int replace, int[,] dp)
    {
        if (dp[length1, length2] != -1)
        {
            return dp[length1, length2];
        }
        if (length1 <= 0)
        {
            return length2 * insert;
        }
        if (length2 <= 0)
        {
            return length1 * delete;
        }
        int answer;
        if (word1[length1 - 1] == word2[length2 - 1])
        {
            answer = this.MinDistance(word1, length1 - 1, word2, length2 - 1, insert, delete, replace, dp);
        }
        else
        {
            answer = Math.Min(this.MinDistance(word1, length1 - 1, word2, length2 - 1, insert, delete, replace, dp) + replace, Math.Min(this.MinDistance(word1, length1 - 1, word2, length2, insert, delete, replace) + delete, this.MinDistance(word1, length1, word2, length2 - 1, insert, delete, replace) + insert));
        }
        dp[length1, length2] = answer;
        return answer;
    }

    public int MinDistance3(string word1, string word2)
    {
        int[,] dp = new int[word1.Length + 1, word2.Length + 1];
        for (int i = 0, insert = 1, delete = 1, replace = 1; i <= word1.Length; i++)
        {
            for (int j = 0; j <= word2.Length; j++)
            {
                if (i == 0 && j == 0)
                {
                    dp[i, j] = 0;
                }
                else if (i == 0 && j != 0)
                {
                    dp[i, j] = j * insert;
                }
                else if (i != 0 && j == 0)
                {
                    dp[i, j] = i * delete;
                }
                else
                {
                    if (word1[i - 1] == word2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Min(dp[i - 1, j - 1] + replace, Math.Min(dp[i - 1, j] + delete, dp[i, j - 1] + insert));
                    }
                }
            }
        }
        return dp[word1.Length, word2.Length];
    }

    public int MinDistance4(string word1, string word2)
    {
        int[] dp = new int[word2.Length + 1];
        for (int i = 0, insert = 1, delete = 1, replace = 1, leftUp, backup; i <= word1.Length; i++)
        {
            leftUp = i * delete;
            for (int j = 0; j <= word2.Length; j++)
            {
                backup = dp[j];
                if (i == 0 && j == 0)
                {
                    dp[j] = 0;
                }
                else if (i == 0 && j != 0)
                {
                    dp[j] = j * insert;
                }
                else if (i != 0 && j == 0)
                {
                    dp[j] = i * delete;
                }
                else
                {
                    if (word1[i - 1] == word2[j - 1])
                    {
                        dp[j] = leftUp;
                    }
                    else
                    {
                        dp[j] = Math.Min(leftUp + replace, Math.Min(dp[j - 1] + insert, dp[j] + delete));
                    }
                }
                leftUp = backup;
            }
        }
        return dp[word2.Length];
    }
}
