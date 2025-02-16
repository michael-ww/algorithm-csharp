namespace Belly.Algorithm.LeetCode;

public class LeetCode688
{
    public double KnightProbability1(int n, int k, int row, int column)
    {
        return this.KnightProbability1Internal(n, k, row, column) / Math.Pow(8, k);
    }

    public double KnightProbability1Internal(int n, int k, int row, int column)
    {
        if (n < 0 || k < 0 || row < 0 || column < 0 || row > n - 1 || column > n - 1)
        {
            return 0;
        }

        if (k == 0)
        {
            return 1;
        }

        return this.KnightProbability1Internal(n, k - 1, row - 2, column - 1) +
                this.KnightProbability1Internal(n, k - 1, row - 1, column - 2) +
                this.KnightProbability1Internal(n, k - 1, row + 1, column - 2) +
                this.KnightProbability1Internal(n, k - 1, row + 2, column - 1) +
                this.KnightProbability1Internal(n, k - 1, row + 2, column + 1) +
                this.KnightProbability1Internal(n, k - 1, row + 1, column + 2) +
                this.KnightProbability1Internal(n, k - 1, row - 1, column + 2) +
                this.KnightProbability1Internal(n, k - 1, row - 2, column + 1);
    }

    public double KnightProbability2(int n, int k, int row, int column)
    {
        double[,,] dp = new double[k + 1, n, n];
        return this.KnightProbability2Internl(n, k, row, column, dp) / Math.Pow(8, k);
    }

    public double KnightProbability2Internl(int n, int k, int row, int column, double[,,] dp)
    {
        if (n < 0 || k < 0 || row < 0 || column < 0 || row > n - 1 || column > n - 1)
        {
            return 0;
        }

        if (k == 0)
        {
            dp[k, row, column] = 1;
        }
        else
        {
            dp[k, row, column] += this.KnightProbability2Internl(n, k - 1, row - 2, column - 1, dp);
            dp[k, row, column] += this.KnightProbability2Internl(n, k - 1, row - 1, column - 2, dp);
            dp[k, row, column] += this.KnightProbability2Internl(n, k - 1, row + 1, column - 2, dp);
            dp[k, row, column] += this.KnightProbability2Internl(n, k - 1, row + 2, column - 1, dp);
            dp[k, row, column] += this.KnightProbability2Internl(n, k - 1, row + 2, column + 1, dp);
            dp[k, row, column] += this.KnightProbability2Internl(n, k - 1, row + 1, column + 2, dp);
            dp[k, row, column] += this.KnightProbability2Internl(n, k - 1, row - 1, column + 2, dp);
            dp[k, row, column] += this.KnightProbability2Internl(n, k - 1, row - 2, column + 1, dp);
        }

        return dp[k, row, column];
    }

    public double KnightProbability3(int n, int k, int row, int column)
    {
        if (n < 0 || k < 0 || row < 0 || column < 0 || row > n - 1 || column > n - 1)
        {
            return 0;
        }

        if (k == 0)
        {
            return 1;
        }

        double[,,] dp = new double[k + 1, n, n];
        for (int step = 0; step <= k; step++)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (step == 0)
                    {
                        dp[step, i, j] = 1;
                    }
                    else
                    {
                        dp[step, i, j] += (step - 1 >= 0 && i - 2 >= 0 && j - 1 >= 0) ? dp[step - 1, i - 2, j - 1] : 0;
                        dp[step, i, j] += (step - 1 >= 0 && i - 1 >= 0 && j - 2 >= 0) ? dp[step - 1, i - 1, j - 2] : 0;
                        dp[step, i, j] += (step - 1 >= 0 && i + 1 < n && j - 2 >= 0) ? dp[step - 1, i + 1, j - 2] : 0;
                        dp[step, i, j] += (step - 1 >= 0 && i + 2 < n && j - 1 >= 0) ? dp[step - 1, i + 2, j - 1] : 0;
                        dp[step, i, j] += (step - 1 >= 0 && i + 2 < n && j + 1 < n) ? dp[step - 1, i + 2, j + 1] : 0;
                        dp[step, i, j] += (step - 1 >= 0 && i + 1 < n && j + 2 < n) ? dp[step - 1, i + 1, j + 2] : 0;
                        dp[step, i, j] += (step - 1 >= 0 && i - 1 >= 0 && j + 2 < n) ? dp[step - 1, i - 1, j + 2] : 0;
                        dp[step, i, j] += (step - 1 >= 0 && i - 2 >= 0 && j + 1 < n) ? dp[step - 1, i - 2, j + 1] : 0;
                    }
                }
            }
        }

        return dp[k, row, column] / Math.Pow(8, k);
    }
}
