namespace Algorithm.LeetCode;

public class LeetCode134
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        if (gas == null || cost == null || gas.Length <= 0 || cost.Length <= 0 || gas.Length != cost.Length)
        {
            return -1;
        }

        for (int leftIndex = 0, rightIndex, length = 0, sum = 0; leftIndex < gas.Length; leftIndex++)
        {
            while (sum >= 0)
            {
                if (length == gas.Length)
                {
                    return leftIndex;
                }
                rightIndex = (leftIndex + length++) % gas.Length;
                sum += gas[rightIndex] - cost[rightIndex];
            }
            length--;
            sum -= gas[leftIndex] - cost[leftIndex];
        }

        return -1;
    }
}
