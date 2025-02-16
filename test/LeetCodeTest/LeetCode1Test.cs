namespace Algorithm.LeetCodeTest;

public class LeetCode1Test
{
    [Theory]
    [InlineData(new int[] { 1, 3, 6, 9, 22 }, 9, new int[] { 1, 2 })]
    [InlineData(new int[] { 1, 3, 6, 9, 22 }, 11, new int[] { -1, -1 })]
    public void TwoSum_ValidInput_ReturnIndexes(int[] nums, int target, int[] expected)
    {
        //Arrange
        LeetCode1 leetCode1 = new();

        //Act
        (int leftIndex, int rightIndex) = leetCode1.TwoSum(nums, target);

        //Assert
        Assert.Equal(expected[0], leftIndex);
        Assert.Equal(expected[1], rightIndex);
    }
}
