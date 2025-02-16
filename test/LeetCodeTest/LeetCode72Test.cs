namespace Algorithm.LeetCodeTest;

public class LeetCode72Test
{
    [Fact]
    public void MinDistance_ValidInput_ReturnMinDistance()
    {
        // Given

        // When
        LeetCode72 leetCode72 = new();
        int answer11 = leetCode72.MinDistance1("horse", "ros");
        int answer12 = leetCode72.MinDistance1("intention", "execution");
        int answer21 = leetCode72.MinDistance2("horse", "ros");
        int answer22 = leetCode72.MinDistance2("intention", "execution");
        int answer31 = leetCode72.MinDistance3("horse", "ros");
        int answer32 = leetCode72.MinDistance3("intention", "execution");
        int answer41 = leetCode72.MinDistance4("horse", "ros");
        int answer42 = leetCode72.MinDistance4("intention", "execution");

        // Then
        Assert.Equal(3, answer11);
        Assert.Equal(5, answer12);
        Assert.Equal(3, answer21);
        Assert.Equal(5, answer22);
        Assert.Equal(3, answer31);
        Assert.Equal(5, answer32);
        Assert.Equal(3, answer41);
        Assert.Equal(5, answer42);
    }
}
