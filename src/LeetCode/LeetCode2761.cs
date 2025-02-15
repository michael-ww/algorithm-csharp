namespace Algorithm.LeetCode;

public class LeetCode2761
{
    public IList<IList<int>> FindPrimePairs(int n)
    {
        IList<IList<int>> answer = new List<IList<int>>();
        if (n < 2)
        {
            return answer;
        }
        for (int i = 2; i < n / 2 + 1; i++)
        {
            if (Utility.IsPrime(i) && Utility.IsPrime(n - i))
            {
                answer.Add([i, n - i]);
            }
        }

        return answer;
    }

    public (int, int) GetPrimeProduct(int n)
    {
        // 如果n为素数，则必然不可能是两个素数之积
        if (Utility.IsPrime(n))
        {
            return (-1, -1);
        }

        for (int i = 2; i <= n; i++)
        {
            if (n % i == 0)
            {
                if (Utility.IsPrime(i) && Utility.IsPrime(n / i))
                {
                    // 如果n为两个素数之积，则n只能分解为这两个因子，因为素数无法再次分解出其他因子，也就是说n不再有其他因子了（因子不包含1和自身）
                    return (i, n / i);
                }
                else
                {
                    // 如果i，j有一个不是素数因子，则说明n存在非素数因子，此时n不可能是素数之积
                    // 如果i，j为相同的素数因子，则n不是满足题意的素数之积
                    // 此时可以判定n不符合要求了，直接退出循环
                    break;
                }
            }
        }

        return (-1, -1);
    }
}
