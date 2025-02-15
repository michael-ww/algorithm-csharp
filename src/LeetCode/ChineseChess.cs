namespace Algorithm.LeetCode;

// 9*10 Coordinates System
// Start Point : (0,0)
public class ChineseChess
{
    public int CalculateWays1(int x, int y, int step)
    {
        if (x < 0 || x > 8 || y < 0 || y > 9)
        {
            return 0;
        }

        if (step <= 0)
        {
            return (x == 0 && y == 0) ? 1 : 0;
        }

        return this.CalculateWays1(x - 1, y + 2, step - 1) +
                this.CalculateWays1(x - 2, y + 1, step - 1) +
                this.CalculateWays1(x - 2, y - 1, step - 1) +
                this.CalculateWays1(x - 1, y - 2, step - 1) +
                this.CalculateWays1(x + 1, y - 2, step - 1) +
                this.CalculateWays1(x + 2, y - 1, step - 1) +
                this.CalculateWays1(x + 2, y + 1, step - 1) +
                this.CalculateWays1(x + 1, y + 2, step - 1);
    }

    public int CalculateWays2(int x, int y, int step)
    {
        int[,,] dp = new int[9, 10, step + 1];
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < step + 1; k++)
                {
                    dp[i, j, k] = -1;
                }
            }
        }
        return this.CalculateWays2Internal(x, y, step, dp);
    }

    public int CalculateWays2Internal(int x, int y, int step, int[,,] dp)
    {
        if (x < 0 || x > 8 || y < 0 || y > 9)
        {
            return 0;
        }

        if (dp[x, y, step] != -1)
        {
            return dp[x, y, step];
        }

        if (step == 0)
        {
            dp[x, y, step] = (x == 0 && y == 0) ? 1 : 0;
        }
        else
        {
            dp[x, y, step] = this.CalculateWays2Internal(x - 1, y + 2, step - 1, dp) +
            this.CalculateWays2Internal(x - 2, y + 1, step - 1, dp) +
            this.CalculateWays2Internal(x - 2, y - 1, step - 1, dp) +
            this.CalculateWays2Internal(x - 1, y - 2, step - 1, dp) +
            this.CalculateWays2Internal(x + 1, y - 2, step - 1, dp) +
            this.CalculateWays2Internal(x + 2, y - 1, step - 1, dp) +
            this.CalculateWays2Internal(x + 2, y + 1, step - 1, dp) +
            this.CalculateWays2Internal(x + 1, y + 2, step - 1, dp);
        }

        return dp[x, y, step];
    }

    public int CalculateWays3(int x, int y, int step)
    {
        if (x < 0 || x > 8 || y < 0 || y > 9 || step < 0)
        {
            return 0;
        }

        if (step == 0)
        {
            return (x == 0 && y == 0) ? 1 : 0;
        }

        int[,,] dp = new int[step + 1, 9, 10];
        for (int k = 0; k <= step; k++)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (k == 0 && i == 0 && j == 0)
                    {
                        dp[k, i, j] = 1;
                    }
                    else if (k == 0 && i != 0 && j != 0)
                    {
                        dp[k, i, j] = 0;
                    }
                    else
                    {
                        dp[k, i, j] += (i - 1 >= 0 && j + 2 < 10 && k - 1 >= 0) ? dp[k - 1, i - 1, j + 2] : 0;
                        dp[k, i, j] += (i - 2 >= 0 && j + 1 < 10 && k - 1 >= 0) ? dp[k - 1, i - 2, j + 1] : 0;
                        dp[k, i, j] += (i - 2 >= 0 && j - 1 >= 0 && k - 1 >= 0) ? dp[k - 1, i - 2, j - 1] : 0;
                        dp[k, i, j] += (i - 1 >= 0 && j - 2 >= 0 && k - 1 >= 0) ? dp[k - 1, i - 1, j - 2] : 0;
                        dp[k, i, j] += (i + 1 < 9 && j - 2 >= 0 && k - 1 >= 0) ? dp[k - 1, i + 1, j - 2] : 0;
                        dp[k, i, j] += (i + 2 < 9 && j - 1 >= 0 && k - 1 >= 0) ? dp[k - 1, i + 2, j - 1] : 0;
                        dp[k, i, j] += (i + 2 < 9 && j + 1 < 10 && k - 1 >= 0) ? dp[k - 1, i + 2, j + 1] : 0;
                        dp[k, i, j] += (i + 1 < 9 && j + 2 < 10 && k - 1 >= 0) ? dp[k - 1, i + 1, j + 2] : 0;
                    }
                }
            }
        }

        return dp[step, x, y];
    }
}
