namespace Algorithm.LeetCodeTest;

public class LeetCode29Test
{
    [Fact]
    public void Divide_ValidInput_Return()
    {
        // Given

        // When
        LeetCode29 leetCode29 = new();
        int answer1 = leetCode29.Divide(10, 3);
        int answer2 = leetCode29.Divide(-7, 3);

        // Then
        Assert.Equal(3, answer1);
        Assert.Equal(-2, answer2);
    }
}
