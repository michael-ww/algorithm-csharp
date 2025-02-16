namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode205Test
{
    [Fact]
    public void IsIsomorphic_ValidInput_ReturnBoolean()
    {
        // Given
        string s1 = "egg", t1 = "add";
        string s2 = "foo", t2 = "bar";
        string s3 = "paper", t3 = "title";

        // When
        LeetCode205 leetCode205 = new();
        bool answer1 = leetCode205.IsIsomorphic(s1, t1);
        bool answer2 = leetCode205.IsIsomorphic(s2, t2);
        bool answer3 = leetCode205.IsIsomorphic(s3, t3);

        // Then
        Assert.True(answer1);
        Assert.False(answer2);
        Assert.True(answer3);
    }
}
