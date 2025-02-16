namespace Belly.Algorithm.LeetCode;

public class LeetCode338
{
    public int[] CountBits1(int n)
    {
        int[] answer = new int[Math.Abs(n) + 1];
        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = int.PopCount(i);
        }

        return answer;
    }

    public int[] CountBits2(int n)
    {
        int[] answer = new int[Math.Abs(n) + 1];
        for (int i = 0; i < answer.Length; i++)
        {
            int count = 0;
            int x = i;
            while (x > 0)
            {
                x &= x - 1;
                count++;
            }
            answer[i] = count;
        }

        return answer;
    }

    public int[] CountBits3(int n)
    {
        int[] answer = new int[Math.Abs(n) + 1];
        int highBit = 0;
        for (int i = 1; i < answer.Length; i++)
        {
            if ((i & (i - 1)) == 0)
            {
                highBit = i;
            }
            answer[i] = answer[i - highBit] + 1;
        }
        return answer;
    }

    public int[] CountBits4(int n)
    {
        int[] bits = new int[Math.Abs(n) + 1];
        for (int i = 1; i < bits.Length; i++)
        {
            bits[i] = bits[i >> 1] + (i & 1);
        }

        return bits;
    }

    public int[] CountBits5(int n)
    {
        int[] bits = new int[Math.Abs(n) + 1];
        for (int i = 1; i < bits.Length; i++)
        {
            bits[i] = bits[i & (i - 1)] + 1;
        }
        return bits;
    }
}
