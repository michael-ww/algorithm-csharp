namespace Algorithm.LeetCode;

public class LeetCode43
{
    public string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0")
        {
            return "0";
        }

        int[] array = new int[num1.Length + num2.Length];
        for (int i = num1.Length - 1; i >= 0; i--)
        {
            int x = num1.ElementAt(i) - '0';
            for (int j = num2.Length - 1; j >= 0; j--)
            {
                int y = num2.ElementAt(j) - '0';
                array[i + j + 1] += x * y;
            }
        }
        for (int i = array.Length - 1; i > 0; i--)
        {
            array[i - 1] += array[i] % 10;
            array[i] %= 10;
        }
        StringBuilder sb = new();
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0 && array[i] == 0)
            {
                continue;
            }
            sb.Append(array[i]);
        }
        return sb.ToString();
    }
}
