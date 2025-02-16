namespace Algorithm.LeetCodeTest;

public class LeetCode383Test
{
    [Fact]
    public void CanConstruct_ValidInput_ReturnBoolean()
    {
        // Given
        string ransomNote1 = "aa", magazine1 = "aab";
        string ransomNote2 = "aa", magazine2 = "ab";

        // When
        LeetCode383 leetCode383 = new();
        bool answer1 = leetCode383.CanConstruct(ransomNote1, magazine1);
        bool answer2 = leetCode383.CanConstruct(ransomNote2, magazine2);

        // Then
        Assert.True(answer1);
        Assert.False(answer2);
    }
}
