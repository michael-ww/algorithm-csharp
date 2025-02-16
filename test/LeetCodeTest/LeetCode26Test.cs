namespace Algorithm.LeetCodeTest;

public class LeetCode26Test
{
    [Fact]
    public void RemoveDuplicates_ValidInput_ReturnLength()
    {
        //Arrange
        int[] nums1 = { 1, 1, 2 };
        int[] nums2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        //Act
        LeetCode26 leetCode26 = new();
        int length1 = leetCode26.RemoveDuplicates(nums1);
        int length2 = leetCode26.RemoveDuplicates(nums2);

        //Assert
        Assert.Equal(2, length1);
        Assert.Equal(5, length2);
    }
}
