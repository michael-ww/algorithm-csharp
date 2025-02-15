namespace Algorithm.LeetCode;

public class LeetCode316
{
    public string RemoveDuplicateLetters(string s)
    {
        int[] counter = new int[26];
        bool[] entered = new bool[26];
        Stack<char> stack = [];
        foreach (var item in s)
        {
            counter[item - 'a']++;
        }
        foreach (var item in s)
        {
            if (!entered[item - 'a'])
            {
                while (stack.Count > 0 && stack.Peek() > item && counter[item - 'a'] > 0)
                {
                    entered[stack.Pop() - 'a'] = false;
                }
                stack.Push(item);
                entered[item - 'a'] = true;
            }
            counter[item - 'a']--;
        }
        StringBuilder sb = new();
        while (stack.Count > 0)
        {
            sb.Insert(0, stack.Pop());
        }
        return sb.ToString();
    }
}
