namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode1079Test
{
    [Fact]
    public void NumTilePossibilities_ValidInput_ReturnPossibilities()
    {
        // Given
        string tiles1 = "AAB";
        string tiles2 = "AAABBC";

        // When
        LeetCode1079 leetCode1079 = new();
        int answer1 = leetCode1079.NumTilePossibilities(tiles1);
        int answer2 = leetCode1079.NumTilePossibilities(tiles2);

        // Then
        Assert.Equal(8, answer1);
        Assert.Equal(188, answer2);
    }
}
