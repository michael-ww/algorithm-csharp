namespace Algorithm.LeetCodeTest;

public class LeetCode639Test
{
    [Fact]
    public void NumDecodings_ValidInput_ReturnWays()
    {
        // Given

        // When
        LeetCode639 leetCode639 = new();
        int answer11 = leetCode639.NumDecodings1("*");
        int answer12 = leetCode639.NumDecodings1("1*");
        int answer13 = leetCode639.NumDecodings1("2*");
        int answer21 = leetCode639.NumDecodings2("*");
        int answer22 = leetCode639.NumDecodings2("1*");
        int answer23 = leetCode639.NumDecodings2("2*");
        int answer31 = leetCode639.NumDecodings3("*");
        int answer32 = leetCode639.NumDecodings3("1*");
        int answer33 = leetCode639.NumDecodings3("2*");
        int answer41 = leetCode639.NumDecodings4("*");
        int answer42 = leetCode639.NumDecodings4("1*");
        int answer43 = leetCode639.NumDecodings4("2*");

        // Then
        Assert.Equal(9, answer11);
        Assert.Equal(18, answer12);
        Assert.Equal(15, answer13);
        Assert.Equal(9, answer21);
        Assert.Equal(18, answer22);
        Assert.Equal(15, answer23);
        Assert.Equal(9, answer31);
        Assert.Equal(18, answer32);
        Assert.Equal(15, answer33);
        Assert.Equal(9, answer41);
        Assert.Equal(18, answer42);
        Assert.Equal(15, answer43);
    }
}
