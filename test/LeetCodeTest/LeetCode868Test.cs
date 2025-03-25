namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode868Test
{
    [Fact]
    public void BinaryGap_ValidInput_ReturnMaxGap()
    {
        // Given
        LeetCode868 leetCode868 = new();

        // When
        int answer1 = leetCode868.BinaryGap(22);
        int answer2 = leetCode868.BinaryGap(8);
        int answer3 = leetCode868.BinaryGap(5);

        // Then
        Assert.Equal(2, answer1);
        Assert.Equal(0, answer2);
        Assert.Equal(2, answer3);
    }
}