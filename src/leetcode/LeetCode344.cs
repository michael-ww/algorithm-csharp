namespace Algorithm.LeetCode;

public class LeetCode344
{
    public void ReverseString(char[] s)
    {
        if (s == null || s.Length < 2)
        {
            return;
        }
        int leftIndex = 0, rightIndex = s.Length - 1;
        while (leftIndex < rightIndex)
        {
            char temp = s[leftIndex];
            s[leftIndex] = s[rightIndex];
            s[rightIndex] = temp;
            leftIndex++;
            rightIndex--;
        }
    }
}
