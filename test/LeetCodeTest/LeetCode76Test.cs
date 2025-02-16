namespace Algorithm.LeetCodeTest;

public class LeetCode76Test
{
    [Fact]
    public void MinWindow_ValidInput_ReturnSubstring()
    {
        // Given
        string source1 = "ADOBECODEBANC", target1 = "ABC";
        string source2 = "a", target2 = "a";
        string source3 = "a", target3 = "aa";

        // When
        LeetCode76 leetCode76 = new();
        string answer1 = leetCode76.MinWindow(source1, target1);
        string answer2 = leetCode76.MinWindow(source2, target2);
        string answer3 = leetCode76.MinWindow(source3, target3);

        // Then
        Assert.Equal("BANC", answer1);
        Assert.Equal("a", answer2);
        Assert.Equal(string.Empty, answer3);
    }
}
