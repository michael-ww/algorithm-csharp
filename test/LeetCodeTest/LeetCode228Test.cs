namespace Algorithm.LeetCodeTest;

public class LeetCode228Test
{
    [Fact]
    public void SummaryRanges_ValidInput_ReturnList()
    {
        // Given
        int[] nums1 = { 0, 1, 2, 4, 5, 7 };
        int[] nums2 = { 0, 2, 3, 4, 6, 8, 9 };

        // When
        LeetCode228 leetCode228 = new();
        IList<string> answer1 = leetCode228.SummaryRanges(nums1);
        IList<string> answer2 = leetCode228.SummaryRanges(nums2);

        // Then "0","2->4","6","8->9"
        Assert.Contains("0->2", answer1);
        Assert.Contains("4->5", answer1);
        Assert.Contains("7", answer1);
        Assert.Contains("0", answer2);
        Assert.Contains("2->4", answer2);
        Assert.Contains("6", answer2);
        Assert.Contains("8->9", answer2);

    }
}
