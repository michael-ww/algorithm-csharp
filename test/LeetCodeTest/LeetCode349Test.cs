namespace Algorithm.LeetCodeTest;

public class LeetCode349Test
{
    [Fact]
    public void Intersection_ValidInput_ReturnArray()
    {
        // Given
        int[] nums11 = { 1, 2, 2, 1 }, nums21 = { 2, 2 };
        int[] nums12 = { 4, 9, 5 }, nums22 = { 9, 4, 9, 8, 4 };

        // When
        LeetCode349 leetCode349 = new();
        int[] answer1 = leetCode349.Intersection1(nums11, nums21);
        int[] answer2 = leetCode349.Intersection1(nums12, nums22);

        int[] answer3 = leetCode349.Intersection2(nums11, nums21);
        int[] answer4 = leetCode349.Intersection2(nums12, nums22);

        // Then
        Assert.Single(answer1);
        Assert.Contains(2, answer1);
        Assert.Equal(2, answer2.Length);
        Assert.Contains(9, answer2);
        Assert.Contains(4, answer2);

        Assert.Single(answer3);
        Assert.Contains(2, answer3);
        Assert.Equal(2, answer4.Length);
        Assert.Contains(9, answer4);
        Assert.Contains(4, answer4);
    }
}
