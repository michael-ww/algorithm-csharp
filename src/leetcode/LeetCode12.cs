namespace Algorithm.LeetCode;

public class LeetCode12
{
    public string IntToRoman(int num)
    {
        SortedDictionary<int, string> symbols = new(Comparer<int>.Create((int x, int y) => y - x)) { { 1000, "M" }, { 900, "CM" }, { 500, "D" }, { 400, "CD" }, { 100, "C" }, { 90, "XC" }, { 50, "L" }, { 40, "XL" }, { 10, "X" }, { 9, "IX" }, { 5, "V" }, { 4, "IV" }, { 1, "I" } };
        StringBuilder sb = new();
        foreach (var item in symbols)
        {
            while (num >= item.Key)
            {
                sb.Append(item.Value);
                num -= item.Key;
            }
            if (num <= 0)
            {
                break;
            }
        }
        return sb.ToString();
    }
}