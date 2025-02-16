namespace Algorithm.LeetCodeTest;

public class LeetCode91Test
{
    [Fact]
    public void NumDecodings_ValidInput_ReturnWays()
    {
        // Given

        // When
        LeetCode91 leetCode91 = new();
        int answer1 = leetCode91.NumDecodings1("11106");
        int answer2 = leetCode91.NumDecodings2("11106");
        int answer3 = leetCode91.NumDecodings3("11106");
        int answer4 = leetCode91.NumDecodings4("11106");

        // Then
        Assert.Equal(2, answer1);
        Assert.Equal(2, answer2);
        Assert.Equal(2, answer3);
        Assert.Equal(2, answer4);
    }
}
