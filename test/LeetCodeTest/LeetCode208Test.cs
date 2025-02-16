namespace Algorithm.LeetCodeTest;

public class LeetCode208Test
{
    [Fact]
    public void Trie_ValidInput_PerformExpectation()
    {
        // Given

        // When
        LeetCode208 trie = new();
        trie.Insert("apple");
        bool answer1 = trie.Search("apple");
        bool answer2 = trie.Search("app");
        bool answer3 = trie.StartsWith("app");
        trie.Insert("app");
        bool answer4 = trie.Search("app");

        // Then
        Assert.True(answer1);
        Assert.False(answer2);
        Assert.True(answer3);
        Assert.True(answer4);
    }
}
