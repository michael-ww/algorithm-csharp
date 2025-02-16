namespace Belly.Algorithm.LeetCode;

public class RobotWalking
{
    // Time Complexity : O(2^steps)
    public int Walk1(int positions, int endPosition, int startPosition, int steps)
    {
        return this.Walking1(positions, endPosition, startPosition, steps);
    }

    public int Walking1(int positions, int endPosition, int currentPosition, int restSteps)
    {
        if (restSteps == 0)
        {
            return currentPosition == endPosition ? 1 : 0;
        }
        else if (currentPosition == 1)
        {
            return this.Walking1(positions, endPosition, restSteps - 1, currentPosition + 1);
        }
        else if (currentPosition == positions)
        {
            return this.Walking1(positions, endPosition, restSteps - 1, currentPosition - 1);
        }
        else
        {
            return this.Walking1(positions, endPosition, restSteps - 1, currentPosition + 1) + this.Walking1(positions, endPosition, restSteps - 1, currentPosition - 1);
        }
    }

    public int Walk2(int positions, int endPosition, int startPosition, int steps)
    {
        int[,] dp = new int[positions, steps];
        for (int position = 0; position < dp.GetLength(0); position++)
        {
            for (int step = 0; step < dp.GetLength(1); step++)
            {
                dp[position, step] = -1;
            }
        }

        return this.Walking2(positions, endPosition, startPosition, steps, dp);
    }

    public int Walking2(int positions, int endPosition, int currentPosition, int restSteps, int[,] dp)
    {
        if (dp[currentPosition, restSteps] != -1)
        {
            return dp[currentPosition, restSteps];
        }

        if (restSteps == 0)
        {
            dp[currentPosition, restSteps] = currentPosition == endPosition ? 1 : 0;
        }
        else if (currentPosition == 1)
        {
            dp[currentPosition, restSteps] = this.Walking2(positions, endPosition, currentPosition + 1, restSteps - 1, dp);
        }
        else if (currentPosition == positions)
        {
            dp[currentPosition, restSteps] = this.Walking2(positions, endPosition, currentPosition - 1, restSteps - 1, dp);
        }
        else
        {
            dp[currentPosition, restSteps] = this.Walking2(positions, endPosition, currentPosition - 1, restSteps - 1, dp) + this.Walking2(positions, endPosition, currentPosition + 1, restSteps - 1, dp);
        }

        return dp[currentPosition, restSteps];
    }

    public int Walk3(int positions, int endPosition, int startPosition, int steps)
    {
        int[,] dp = new int[steps + 1, positions];
        for (int rest = 0; rest <= steps; rest++)
        {
            for (int current = 1; current < positions; current++)
            {
                if (rest == 0)
                {
                    if (current == endPosition - 1)
                    {
                        dp[rest, current] = 1;
                    }
                    else
                    {
                        dp[rest, current] = 0;
                    }
                }
                else
                {
                    if (current == 1)
                    {
                        dp[rest, current] = dp[rest - 1, current + 1];
                    }
                    else if (current == positions - 1)
                    {
                        dp[rest, current] = dp[rest - 1, current - 1];
                    }
                    else
                    {
                        dp[rest, current] = dp[rest - 1, current - 1] + dp[rest - 1, current + 1];
                    }
                }
            }
        }

        return dp[steps, endPosition - 1];
    }
}
