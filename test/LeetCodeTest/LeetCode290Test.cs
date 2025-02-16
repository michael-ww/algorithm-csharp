namespace Algorithm.LeetCodeTest;

public class LeetCode290Test
{
    [Fact]
    public void WordPattern_ValidInput_ReturBoolean()
    {
        // Given
        string pattern1 = "abba", s1 = "dog cat cat dog";
        string pattern2 = "abba", s2 = "dog cat cat fish";
        string pattern3 = "aaaa", s3 = "dog cat cat dog";

        // When
        LeetCode290 leetCode290 = new();
        bool answer1 = leetCode290.WordPattern(pattern1, s1);
        bool answer2 = leetCode290.WordPattern(pattern2, s2);
        bool answer3 = leetCode290.WordPattern(pattern3, s3);

        // Then
        Assert.True(answer1);
        Assert.False(answer2);
        Assert.False(answer3);
    }
}
