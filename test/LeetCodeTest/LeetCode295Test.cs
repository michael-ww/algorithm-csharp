namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode295Test
{
    [Fact]
    public void FindMedian_ValidInput_ReturnMedian()
    {
        //Arrange
        int[] nums = { 6, 3, -2, 8, 22, 1, -9 };

        //Act
        MedianFinder medianFinder = new();
        for (int i = 0; i < nums.Length / 2; i++)
        {
            medianFinder.AddNum(nums[i]);
        }

        double median1 = medianFinder.FindMedian();

        for (int i = 0; i < nums.Length; i++)
        {
            medianFinder.AddNum(nums[i]);
        }

        double median2 = medianFinder.FindMedian();

        //Assert
        Assert.Equal(3, median1);
        Assert.Equal(3, median2);
    }
}
