namespace Algorithm.LeetCodeTest;

public class LeetCode27Test
{
    [Fact]
    public void RemoveElement_ValidInput_ReturnLength()
    {
        //Arrange
        int[] nums1 = { 3, 2, 2, 3 };
        int target1 = 3;
        int[] nums2 = { 0, 1, 2, 2, 3, 0, 4, 2 };
        int target2 = 2;
        int[] nums3 = { 2, 2, 2, 2 };
        int target3 = 2;

        //Act
        LeetCode27 leetCode27 = new();
        int length1 = leetCode27.RemoveElement(nums1, target1);
        int length2 = leetCode27.RemoveElement(nums2, target2);
        int length3 = leetCode27.RemoveElement(nums3, target3);

        //Assert
        Assert.Equal(2, length1);
        Assert.Equal(2, nums1[0]);
        Assert.Equal(2, nums1[1]);
        Assert.Equal(5, length2);
        Assert.Equal(0, nums2[0]);
        Assert.Equal(1, nums2[1]);
        Assert.Equal(3, nums2[2]);
        Assert.Equal(0, nums2[3]);
        Assert.Equal(4, nums2[4]);
        Assert.Equal(0, length3);
    }
}
