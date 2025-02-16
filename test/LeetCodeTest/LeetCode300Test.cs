namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode300Test
{
    [Fact]
    public void LengthOfLIS_ValidInput_ReturnLengthOfLTS()
    {
        // Arrange

        // Act
        LeetCode300 leetCode300 = new();
        int length1 = leetCode300.LengthOfLIS1([10, 9, 2, 5, 3, 7, 101, 18]);
        int length2 = leetCode300.LengthOfLIS1([0, 1, 0, 3, 2, 3]);
        int length3 = leetCode300.LengthOfLIS1([7, 7, 7, 7, 7, 7, 7]);

        // Assert
        Assert.Equal(4, length1);
        Assert.Equal(4, length2);
        Assert.Equal(1, length3);

    }
}
