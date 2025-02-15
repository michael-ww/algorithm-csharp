namespace Algorithm.LeetCode;

public class GiniCoefficient
{
    public double Experiment(int population, int round)
    {
        double[] wealth = new double[population];
        Array.Fill(wealth, 100);
        for (int i = 0; i < round; i++)
        {
            for (int j = 0; j < population; j++)
            {
                if (wealth[j] <= 0)
                {
                    continue;
                }
                int recipient;
                do
                {
                    recipient = Random.Shared.Next(population);
                } while (recipient == j);
                wealth[j]--;
                wealth[recipient]++;
            }
        }

        return this.Caculate(wealth);
    }

    public double Caculate(double[] wealth)
    {
        double totalWealth = 0;
        double totalAbsoluteDifferences = 0;
        for (int i = 0; i < wealth.Length; i++)
        {
            totalWealth += wealth[i];
            for (int j = 0; j < wealth.Length; j++)
            {
                totalAbsoluteDifferences += Math.Abs(wealth[i] - wealth[j]);
            }
        }

        return totalAbsoluteDifferences / (2 * wealth.Length * totalWealth);
    }
}
