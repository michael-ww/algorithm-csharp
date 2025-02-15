namespace Algorithm.LeetCode;

public static class Utility
{
    public static void Swap<T>(T[] nums, int i, int j)
    {
        (nums[i], nums[j]) = (nums[j], nums[i]);
    }

    public static void Swap<T>(IList<T> nums, int i, int j)
    {
        (nums[i], nums[j]) = (nums[j], nums[i]);
    }

    public static void Reverse<T>(T[] nums, int startIndex, int endIndex)
    {
        if (startIndex >= endIndex)
        {
            return;
        }
        startIndex = startIndex < 0 ? 0 : startIndex;
        endIndex = endIndex > nums.Length - 1 ? nums.Length - 1 : endIndex;
        while (startIndex < endIndex)
        {
            Utility.Swap(nums, startIndex, endIndex);
            startIndex++;
            endIndex--;
        }
    }

    public static ListNode Reverse(ListNode head)
    {
        ListNode previous = null;
        while (head != null)
        {
            ListNode next = head.Next;
            head.Next = previous;
            previous = head;
            head = next;
        }
        return previous;
    }

    public static bool IsPrime(int n)
    {
        if (n < 2) return false;
        int r = (int)Math.Sqrt(n);
        for (int d = 2; d <= r; d++)
        {
            if (n % d == 0) return false;
        }
        return true;
    }

    public static bool IsPalindrome(int n)
    {
        if (n < 0) return false;
        int reversed = 0;
        while (n > reversed)
        {
            reversed = reversed * 10 + n % 10;
            n /= 10;
        }
        return n == reversed || n == reversed / 10;
    }

    public static int GreatestCommonDivisor(int x, int y)
    {
        return y == 0 ? x : GreatestCommonDivisor(y, x % y);
    }
}